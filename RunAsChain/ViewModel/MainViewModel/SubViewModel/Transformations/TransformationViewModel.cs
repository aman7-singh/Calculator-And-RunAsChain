using RunAsChain.Model.Interface;
using RunAsChain.ViewModel.MainViewModel.SubViewModel.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunAsChain.ViewModel.MainViewModel.SubViewModel.Transformations
{
    public class TransformationViewModel:Notify
    {
        private List<string> TempList = new List<string>() ;
        private List<string> _chainList;

        public List<string> ChainList
        {
            get { return _chainList; }
            set
            {
                _chainList = value;
                RaisePropertyChanged(this, "ChainList");
            }
        }
        string path = @"C:\Users\1994a\source\repos\Calculator\RunAsChain\Model\RunAsChain12.xml";
        public TransformationViewModel()
        {
            TempList.Add(path);
            ChainList = TempList;
        }
    }
}
