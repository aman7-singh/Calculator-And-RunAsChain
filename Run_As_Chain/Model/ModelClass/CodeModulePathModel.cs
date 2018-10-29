using Run_As_Chain.Model.ModelInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Run_As_Chain.Model.ModelClass
{
    class CodeModulePathModel: ICodeModulePathModel
    {
        private XmlEnum _elementName;
        private string _codeModulePath;

        public string CodeModulePath
        {
            get { return _codeModulePath; }
        }

        public CodeModulePathModel(XmlEnum elementName, string basPath)
        {
            _elementName = elementName;
            _codeModulePath = basPath;
        }
    }
}
