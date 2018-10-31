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

        private ICodeModulesModel _codemodules;

        public ICodeModulesModel CodeModules
        {
            get { return _codemodules; }
        }

        private ITransformationVariablesModel _tfVariables;

        public ITransformationVariablesModel TfVariables
        {
            get { return _tfVariables; }
        }

        public void  AddMap(XmlEnum ElementName, string sequence, string name, string mapFilePath, string sourceFilePath, string targetFilePath,
            ICodeModulesModel bas, ITransformationVariablesModel variable)
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

    }
}
