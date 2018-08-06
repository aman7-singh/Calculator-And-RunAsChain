using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunAsChain.ViewModel.MainViewModel.SubViewModel.Menu.Delegate
{
    public class MenuArgs:EventArgs
    {
        public string SelectedItem { get; set; }
    }
}
