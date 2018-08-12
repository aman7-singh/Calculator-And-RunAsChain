using RunAsChain.Model.Interface;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunAsChain.ViewModel.MainViewModel.SubViewModel.Tab
{
    public class BasViewModel:ICodeModules
    {
        public ObservableCollection<ICodeModule> BasFilePathList { get; set; }
    }
}
