using RunAsChain.Model.CodeModule;
using RunAsChain.Model.Interface;
using RunAsChain.Model.TransformationVariables;
using System.Collections.ObjectModel;
using System.Linq;
using System.Xml.Linq;

namespace RunAsChain.Model
{
    class XmlToObjectBuilder
    {
        public ObservableCollection<IMap> ModelObj( string RunAsChainFile)
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
            var ml = new ObservableCollection<IMap>();
            foreach(var item in RunAsChainXml)
            {
                string mp = item.MapFilePath;
                string sp =  item.SourceFilePath;
                string tp = item.TargetFilePath;
                var basobj = new ObservableCollection<string>();

                foreach (var bas in item.BasFiles)
                {
                    basobj.Add(bas.BasPath);
                }
                var bl = new CodeModules(basobj);

                var Transobj = new ObservableCollection<ITransformationVariable>();
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
