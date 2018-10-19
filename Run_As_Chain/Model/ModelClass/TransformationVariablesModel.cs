using Run_As_Chain.Model.ModelInterface;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Run_As_Chain.Model.ModelClass
{
    class TransformationVariablesModel : ITransformationVariablesModel
    {
        private ObservableCollection<IVariableModel> _tfVariables;

        public ObservableCollection<IVariableModel> TfVariables
        {
            get { return _tfVariables; }
          //  set { _tfVariables = value; }
        }

        public void AddTfVariable(IVariableModel variable)
        {
            TfVariables.Add(variable);
        }
    }
}
