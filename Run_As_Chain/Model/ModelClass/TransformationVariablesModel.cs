using Run_As_Chain.Model.ModelInterface;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Run_As_Chain.Model.ModelClass
{
    public class TransformationVariablesModel : ITransformationVariablesModel
    {
        private XmlEnum _elementName;
        private ObservableCollection<IVariableModel> _tfVariables=new ObservableCollection<IVariableModel>();

        public ObservableCollection<IVariableModel> TfVariables
        {
            get { return _tfVariables; }
        }

        public TransformationVariablesModel(XmlEnum elementName)
        {
            _elementName = elementName;
        }
        public void AddVariable(IVariableModel variable)
        {
            TfVariables.Add(variable);
        }
    }
}
