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
        private string _codeModulePath;

        public string CodeModulePath
        {
            get { return _codeModulePath; }
         //   set { _codeModulePath = value; }
        }

    }
}
