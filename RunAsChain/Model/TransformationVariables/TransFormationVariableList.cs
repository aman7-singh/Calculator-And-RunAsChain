using RunAsChain.Model.Interface;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunAsChain.Model.TransformationVariables
{
    public class TransFormationVariableList: ITransFormationVariableList
    {
        private List<ITransformationVariable> _tVariableList;

        public TransFormationVariableList(List<ITransformationVariable> transobj)
        {
            this._tVariableList = transobj;
        }

        public ObservableCollection<ITransformationVariable> TVariableList
        {
            get { return _tVariableList; }
            set { _tVariableList = value; }
        }

    }
}
