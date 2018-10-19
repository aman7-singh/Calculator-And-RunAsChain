﻿using Run_As_Chain.Model.ModelInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Run_As_Chain.Model.ModelClass
{
    class VariableModel: IVariableModel
    {
        private string _value;

        public string Value
        {
            get { return _value; }
           // set { _value = value; }
        }

        private string _isPublic;

        public string IsPublic
        {
            get { return _isPublic; }
            // set { _isPublic = value; }
        }
        private string _initialValue;

        public string InitialValue
        {
            get { return _initialValue; }
            // set { _initialValue = value; }
        }

        VariableModel(string value, string isPublic, string initialValue)
        {
            _value = value;
            _isPublic = isPublic;
            _initialValue = initialValue;
        }
    }
}
