using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace RunAsChain.Model
{
    class XmlToObjectBuilder
    {

        public String RunAsChain { get; set; }
        private string _runAsChainFile = @"C:\Users\1994a\source\repos\Calculator\RunAsChain\Model\RunAsChain.xml";

        public string RunAsChainFile
        {
            get { return _runAsChainFile; }
            set { _runAsChainFile = value; }
        }

        public XmlToObjectBuilder()
        {
            ModelObj();
            ObjectFiller();
        }


        public void ModelObj()
        {
            var xml = XDocument.Load(RunAsChainFile);
            var RunAsChainXml = xml?.Descendants("Map")
                              .Select(Chain => new
                              {
                                  Sequence = Chain?.Attribute("Sequence")?.Value,
                                  MapFilePath = Chain?.Element("MapFilePath")?.Attribute("Location").Value,
                                  SourceFilePath = Chain?.Element("SourceFilePath")?.Attribute("Location").Value,
                                  TargetFilePath = Chain?.Element("TargetFilePath")?.Attribute("Location").Value,
                                  BasFiles = xml?.Descendants("CodeModules")
                                                  .Select(bas => new
                                                  {
                                                      BasPath = bas.Element("CodeModulePath")?.Attribute("Location").Value
                                                  }),
                                  TransformationVariable = xml?.Descendants("TransformationVariables")
                                                  .Select(bas => new
                                                  {
                                                      Variable = bas?.Element("Variable")?.Attribute("Value").Value,
                                                      IsPublic = bas?.Element("Variable")?.Attribute("Value").Value,
                                                      InitialValue = bas?.Element("Variable")?.Attribute("Value").Value
                                                  })
                              });
            


        }
        public void ObjectFiller()
        {
            
        }
    }
}
