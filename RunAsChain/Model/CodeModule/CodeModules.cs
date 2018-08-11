using RunAsChain.Model.Interface;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunAsChain.Model.CodeModule
{
    public class CodeModules : ICodeModules
    {
        public ObservableCollection<string> BasFilePathList { get; set; }
        public CodeModules(ObservableCollection<string> _basFilePath)
        {
            this.BasFilePathList = _basFilePath;
        }
    }
}
