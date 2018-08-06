using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunAsChain.Model.Interface
{
    public interface ICodeModules
    {
        List<ICodeModule> BasFilePathList { get; }
    }
}
