using Run_As_Chain.Model.ModelClass;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Run_As_Chain.Model.ModelInterface
{
    public interface ITransformationVariablesModel
    {
        ObservableCollection<IVariableModel> TfVariables { get; }

        void AddVariable(IVariableModel variable);
    }
}
