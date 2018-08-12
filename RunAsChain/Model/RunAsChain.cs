using RunAsChain.Model.Interface;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunAsChain.Model
{
    public class RunAsChain : IRunAsChain
    {
        public ObservableCollection<IMap> Chain { get; set; }
        public string ChainPath { get; set; }
    }
}
