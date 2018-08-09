using RunAsChain.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunAsChain.Model
{
    public class RunAsChain 
    {
        public List<IMap> Chain { get ; set ; }

        public RunAsChain(List<IMap> chain)
        {
            Chain = chain;
        }
    }
}
