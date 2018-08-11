using RunAsChain.Model.Interface;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunAsChain.ViewModel.MainViewModel.SubViewModel.Tab
{
    public class MapViewModel
    {
        private ObservableCollection<IMap> _allMaps;

        public ObservableCollection<IMap> AllMaps
        {
            get { return _allMaps; }
            set { _allMaps = value; }
        }

        public MapViewModel(ObservableCollection<IMap> maps)
        {
            AllMaps = maps;
        }

    }
}
