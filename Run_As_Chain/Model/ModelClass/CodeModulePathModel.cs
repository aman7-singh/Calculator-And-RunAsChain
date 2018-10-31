using Run_As_Chain.Model.ModelInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Run_As_Chain.Model.ModelClass
{
    public class CodeModulePathModel: ICodeModulePathModel
    {
        private XmlEnum _elementName;
        private string _codeModulePath;

        public string CodeModulePath
        {
            get { return _codeModulePath; }
        }
        public CodeModulePathModel(XmlEnum elementName)
        {
            _elementName = elementName;
        }
        public void AddCodeModulePathModel(XmlEnum elementName, string basPath)
        {
            _elementName = elementName;
            _codeModulePath = basPath;
        }
    }
}
