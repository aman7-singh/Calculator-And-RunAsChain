using RunAsChain.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunAsChain.Model.TargetFile
{
    public class TargetFilePath: ITargetFilePath
    {
        private string _racTargetFilePath;

        public string RACTargetFilePath
        {
            get { return _racTargetFilePath; }
            set { _racTargetFilePath = value; }
        }
        public TargetFilePath(string t)
        {
            _racTargetFilePath = t;
        }
    }
}
