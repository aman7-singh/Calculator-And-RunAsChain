using Run_As_Chain.Model.ModelClass;
using Run_As_Chain.Model.ModelInterface;
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
        public TransformationModel XmlToObject(string xmlPath)
        {
            XDocument doc = XDocument.Load(xmlPath);

            var ChainObj = new TransformationModel(XmlEnum.Transformation);            
            var processingStepObj = new ProcessingStepsModel(XmlEnum.ProcessingSteps);

            var processingSteps = doc.Descendants("Map");
            foreach (var step in processingSteps)
            {
                var MapObj = new MapModel(XmlEnum.Map);
                var BasObj = new CodeModulePathModel(XmlEnum.CodeModulePath);
                var BasesObj = new CodeModulesModel(XmlEnum.CodeModules);
                var VariableObj = new VariableModel(XmlEnum.TransformationVariables);
                var VariablesObj = new TransformationVariablesModel(XmlEnum.TransformationVariables);

                var Bas = step.Descendants("CodeModules");
                foreach (var b in Bas)
                {
                    BasObj.AddCodeModulePathModel(XmlEnum.CodeModulePath,
                              b.Element("CodeModulePath").Attribute("Location").Value);
                    BasesObj.AddCodeModule(BasObj);
                }

                var TransformationVariables = step.Descendants("TransformationVariables").Elements("Variable");
                foreach (var v in TransformationVariables)
                {
                    VariableObj.AddVariable(XmlEnum.Variable,
                    v.Attribute("Value").Value,
                    v.Attribute("IsPublic").Value,
                    v.Attribute("InitialValue").Value);
                    VariablesObj.AddVariable(VariableObj);
                }

                 MapObj.AddMap(XmlEnum.Map,
                          step.Attribute("Sequence").Value,
                          step.Attribute("Name").Value,
                          step.Element("MapFilePath").Attribute("Location").Value,
                          step.Element("SourceFilePath").Attribute("Location").Value,
                          step.Element("TargetFilePath").Attribute("Location").Value,
                          BasesObj,
                          VariablesObj);

                processingStepObj.AddMap(MapObj);
            }

            var Chain = doc.Descendants("Transformation");
            foreach (var t in Chain)
            {
                ChainObj.AddTransformationModel(XmlEnum.Transformation,
                t.Attribute("createdon").Value,
                t.Attribute("createdby").Value,
                processingStepObj);
            }
            return ChainObj;
        }
    }
}
