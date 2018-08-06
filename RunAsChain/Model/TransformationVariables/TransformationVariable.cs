using RunAsChain.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunAsChain.Model.TransformationVariables
{
    public class TransformationVariable: ITransformationVariable
    {
        private string _tVariable;

        public string TVariable
        {
            get { return _tVariable; }
            set { _tVariable = value; }
        }

        private bool _isPublic;

        public bool IsPublic
        {
            get { return _isPublic; }
            set { _isPublic = value; }
        }

        private String _initialValue;

        public String InitialValue
        {
            get { return _initialValue; }
            set { _initialValue = value; }
        }


    }
}
