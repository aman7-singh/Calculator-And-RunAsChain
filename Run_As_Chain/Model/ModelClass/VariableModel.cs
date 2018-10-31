using Run_As_Chain.Model.ModelInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Run_As_Chain.Model.ModelClass
{
    public class VariableModel: IVariableModel
    {
        private XmlEnum _elementName;
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
        public VariableModel(XmlEnum elementName)
        {
            _elementName = elementName;
        }
        public void  AddVariable(XmlEnum elementName, string value, string isPublic, string initialValue)
        {
            _elementName = elementName;
            _value = value;
            _isPublic = isPublic;
            _initialValue = initialValue;
        }
    }
}
