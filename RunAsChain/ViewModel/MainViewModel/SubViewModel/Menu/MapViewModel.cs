using RunAsChain.Model;
using RunAsChain.Model.Interface;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunAsChain.ViewModel.MainViewModel.SubViewModel.Menu
{
    public class MapViewModel:Notify
    {
        private ObservableCollection<IMap> _MapList = new ObservableCollection<IMap>();
        public ObservableCollection<IMap> MapList
        {
            get { return _MapList; }
            set
            {
                _MapList = value;
                RaisePropertyChanged(this, "MapList");
            }
        }
        public MapViewModel(string path, ObservableCollection<IMap> map)
        {
            MapList = map;
        }
    }
}
