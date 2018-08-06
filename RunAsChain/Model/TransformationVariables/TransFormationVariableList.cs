using RunAsChain.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunAsChain.Model.TransformationVariables
{
    public class TransFormationVariableList: ITransFormationVariableList
    {
        private List<ITransformationVariable> _tVariableList;

        public List<ITransformationVariable> TVariableList
        {
            get { return _tVariableList; }
            set { _tVariableList = value; }
        }

    }
}
