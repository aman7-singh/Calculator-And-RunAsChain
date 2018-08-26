using RunAsChain.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunAsChain.ViewModel.Command
{
    public class MapChangedEventArgs:EventArgs
    {
        public IMap Map { get; set; }       
    }
    public class ChainChangedEventArgs : EventArgs
    {
        public IRunAsChain Chain { get; set; }
    }
}
