using RunAsChain.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunAsChain.Model.SourceFile
{
    public class SourceFilePath: ISourceFilePath
    {
        private string _sourceFilePath;

        public string RACSourceFilePath
        {
            get { return _sourceFilePath; }
            set { _sourceFilePath = value; }
        }

    }
}
