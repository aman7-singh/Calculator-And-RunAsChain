using Run_As_Chain.Model.ModelClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Run_As_Chain.Model
{
    public class ModelObjectBuilder
    {
        string xmlPath = @"D:\VisualStudio\Calculator-And-RunAsChain\Run_As_Chain\Resource\RunAsChain1.xml";
        public void XmlToObject(string xmlPath)
        {
            XDocument doc = XDocument.Load(xmlPath);           

            var processingSteps = doc.Descendants("Map");

            var processingStepObj = new ProcessingStepsModel(XmlEnum.ProcessingSteps);

            foreach (var step in processingSteps)
            {
                var MapObj = new MapModel(XmlEnum.Map);

                var Bas = (from b in step.Descendants("CodeModules")
                          select new CodeModulePathModel(XmlEnum.CodeModulePath,
                          b.Element("CodeModulePath").Attribute("Location").Value)).ToList();

                var TransformationVariables = (from v in step.Descendants("TransformationVariables").Elements("Variable")
                                              select new VariableModel(XmlEnum.Variable,
                                              v.Attribute("Value").Value,
                                              v.Attribute("IsPublic").Value,
                                              v.Attribute("InitialValue").Value)).ToList();

                var Map =  new MapModel(XmlEnum.Map,
                          step.Attribute("Sequence").Value,
                          step.Attribute("Name").Value,
                          step.Element("MapFilePath").Attribute("Location").Value,
                          step.Element("SourceFilePath").Attribute("Location").Value,
                          step.Element("TargetFilePath").Attribute("Location").Value,
                          Bas,
                          TransformationVariables);

                processingStepObj.AddMap( Map);
            }

            var ChainObj = from t in doc.Descendants("Transformation")
                           select new TransformationModel(XmlEnum.Transformation,
                           t.Attribute("createdon").Value,
                           t.Attribute("createdby").Value,
                           processingStepObj);
        }
    }
}
