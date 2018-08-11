using RunAsChain.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunAsChain.ViewModel.MainViewModel.SubViewModel.Tab
{
    public class MapViewModel
    {
        public List<IMap> AllMaps { get; set; }
        public MapViewModel(List<IMap> maps)
        {
            AllMaps = maps;
        }

    }
}
