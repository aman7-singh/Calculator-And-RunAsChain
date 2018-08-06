using RunAsChain.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunAsChain.Model.CodeModule
{
    public class CodeModules:ICodeModules
    {
        private List<ICodeModule> _basFilePathList;

        public List<ICodeModule> BasFilePathList
        {
            get { return _basFilePathList; }
            set { _basFilePathList = value; }
        }

    }
}
