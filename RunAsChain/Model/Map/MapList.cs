using RunAsChain.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunAsChain.Model.Map
{
    public class MapList : IMapList
    {
        public List<IMap> maps { get ; set ; }
        
    }
}
