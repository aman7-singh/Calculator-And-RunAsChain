using RunAsChain.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunAsChain.Model.CodeModule
{
    public class CodeModule: ICodeModule
    {
        private string _basFilePayh;

        public string BasFilePath
        {
            get { return _basFilePayh; }
            set { _basFilePayh = value; }
        }

    }
}
