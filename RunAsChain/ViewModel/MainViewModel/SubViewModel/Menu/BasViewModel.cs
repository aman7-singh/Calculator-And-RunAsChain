using RunAsChain.Model.Interface;
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
        private ObservableCollection<ICodeModule> _MapList = new ObservableCollection<ICodeModule>();
        public ObservableCollection<ICodeModule> BasList
        {
            get { return _MapList; }
            set
            {
                _MapList = value;
                RaisePropertyChanged(this, "BasList");
            }
        }
        public BasViewModel(string path, ObservableCollection<ICodeModule> bas)
        {
            BasList = bas;
        }
    }
}
