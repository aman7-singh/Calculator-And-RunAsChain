using RunAsChain.Model.Interface;
using RunAsChain.Model.SourceFile;
using RunAsChain.Model.TargetFile;
using RunAsChain.Model.TransformationVariables;
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

        public RunAsChain RunAsChain { get; set; }
        private string _runAsChainFile = @"C:\Users\1994a\source\repos\Calculator\RunAsChain\Model\RunAsChain.xml";

        public string RunAsChainFile
        {
            get { return _runAsChainFile; }
            set { _runAsChainFile = value; }
        }

        //public XmlToObjectBuilder()
        //{
        //    ModelObj();
        //}


        public List<IMap> ModelObj( string RunAsChainFile)
        {
            var xml = XDocument.Load(RunAsChainFile);
            var RunAsChainXml = xml?.Descendants("Map")
                              .Select(Chain => new
                              {
                                  Sequence = Chain?.Attribute("Sequence")?.Value,
                                  MapFilePath = Chain?.Element("MapFilePath")?.Attribute("Location").Value,
                                  SourceFilePath = Chain?.Element("SourceFilePath")?.Attribute("Location").Value,
                                  TargetFilePath = Chain?.Element("TargetFilePath")?.Attribute("Location").Value,
                                  BasFiles = Chain?.Descendants("CodeModulePath")
                                                  .Select(bas => new
                                                  {
                                                      BasPath = bas?.Attribute("Location").Value
                                                  }).ToList(),
                                  TransformationVariable = Chain?.Descendants("Variable")
                                                  .Select(Tran => new
                                                  {
                                                      Variable = Tran?.Attribute("Value").Value,
                                                      IsPublic = Tran?.Attribute("IsPublic").Value,
                                                      InitialValue = Tran?.Attribute("InitialValue").Value
                                                  }).ToList()
                              }).ToList();

            
            var Trans =  RunAsChainXml.ToList();
            var ml = new List<IMap>();
            foreach(var item in RunAsChainXml)
            {
                var mp = new Map_Path.Mappath(item.MapFilePath);
                var sp =  new SourceFilePath(item.SourceFilePath);
                var tp =  new TargetFilePath(item.TargetFilePath);
                var basobj = new List<ICodeModule>();

                foreach (var bas in item.BasFiles)
                {
                    basobj.Add(new CodeModule.CodeModule(bas.BasPath));
                }
                var bl = new CodeModule.CodeModules(basobj);

                var Transobj = new List<ITransformationVariable>();
                foreach (var tran in item.TransformationVariable)
                {
                    Transobj.Add(new TransformationVariable("", false, ""));
                }
                var  tl = new TransFormationVariableList(Transobj);

                ml.Add(new Map.Map(mp, sp, tp, bl, tl));
            }
            
            return ml;
        }
    }
}
