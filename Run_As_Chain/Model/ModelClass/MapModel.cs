using Run_As_Chain.Model.ModelInterface;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Run_As_Chain.Model.ModelClass
{
    class MapModel:IMapModel
    {
        private XmlEnum _elementName;
        private string _sequence;

        public string Sequence
        {
            get { return _sequence; }
            set { _sequence = value; }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _mapFilePath;

        public string MapFilePath
        {
            get { return _mapFilePath; }
            set { _mapFilePath = value; }
        }

        private string _sourceFilePath;

        public string SourceFilePath
        {
            get { return _sourceFilePath; }
            set { _sourceFilePath = value; }
        }

        private string _targetFilePath;

        public string TargetFilePath
        {
            get { return _targetFilePath; }
            private set { _targetFilePath = value; }
        }

        private List<CodeModulePathModel> _codemodules;

        public List<CodeModulePathModel> CodeModules
        {
            get { return _codemodules; }
        }

        private List<VariableModel> _tfVariables;

        public List<VariableModel> TfVariables
        {
            get { return _tfVariables; }
        }

        public MapModel(XmlEnum ElementName, string sequence, string name, string mapFilePath, string sourceFilePath, string targetFilePath,
            List<CodeModulePathModel> bas, List<VariableModel> variable)
        {
            _sequence = sequence;
            _name = name;
            _mapFilePath = mapFilePath;
            _sourceFilePath = sourceFilePath;
            _targetFilePath = targetFilePath;
            _codemodules = bas;
            _tfVariables = variable;
        }

        public MapModel(XmlEnum elementName)
        {
            _elementName = elementName;
        }

        public void AddBas(ICodeModulePathModel path)
        {
            CodeModulesModel baslist = new CodeModulesModel();
            baslist.AddCodeModule(path);
        }


    }
}
