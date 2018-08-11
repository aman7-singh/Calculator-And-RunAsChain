using RunAsChain.Model.Interface;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunAsChain.Model.Map
{
    public class MapList : IMapList
    {
        public ObservableCollection<IMap> maps { get ; set ; }
        
    }
}
