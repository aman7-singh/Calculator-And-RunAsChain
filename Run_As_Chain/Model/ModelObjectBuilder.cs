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
        string xmlPath = @"D:\VisualStudio\Calculator-And-RunAsChain\Run_As_Chain\Resource\RunAsChain.xml";
        public void XmlToObject()
        {
            var doc = new XDocument(xmlPath);
            var ChainObj = from t in doc.Descendants("Transformation")
                           select new TransformationModel(XmlEnum.Transformation,
                           t.Attribute("createdon").Value,
                           t.Attribute("createdby").Value);
            var processingSteps = from p in doc.Descendants("ProcessingSteps")
                                  select new ProcessingStepsModel();

            var Map = from m in doc.Descendants("Map")
                      select new MapModel(XmlEnum.Map,
                      m.Attribute("Sequence").Value,
                      m.Attribute("Name").Value,
                      m.Element("MapFilePath").Value,
                      m.Element("SourceFilePath").Value,
                      m.Element("TargetFilePath").Value);

            var Bas = from b in doc.Descendants("CodeModules")
                      select new CodeModulePathModel(XmlEnum.CodeModulePath,
                      b.Element("CodeModulePath").Value);

            var TransformationVariables = from v in doc.Descendants("TransformationVariables").Elements("Variable")
                                          select new VariableModel(XmlEnum.Variable,
                                          v.Attribute("Value").Value,
                                          v.Attribute("IsPublic").Value,
                                          v.Attribute("InitialValue").Value);
        }
    }
}
