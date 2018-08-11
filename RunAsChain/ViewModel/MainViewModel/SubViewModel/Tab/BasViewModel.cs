using RunAsChain.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunAsChain.ViewModel.MainViewModel.SubViewModel.Tab
{
    public class BasViewModel:ICodeModules
    {

        public List<ICodeModule> BasFilePathList { get; set; }

        public BasViewModel()
        {
        }
        public void BasFilesList()
        {
            BasFilePathList = BasFilePathList;
        }
    }
}
