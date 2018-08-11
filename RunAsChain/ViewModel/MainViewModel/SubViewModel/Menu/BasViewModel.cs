using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunAsChain.ViewModel.MainViewModel.SubViewModel.Menu
{
    public class BasViewModel:Notify
    {
        private ObservableCollection<string> _MapList = new ObservableCollection<string>();
        public ObservableCollection<string> BasList
        {
            get { return _MapList; }
            set
            {
                _MapList = value;
                RaisePropertyChanged(this, "BasList");
            }
        }
        public BasViewModel(string path, ObservableCollection<string> bas)
        {
            BasList = bas;
        }
    }
}
