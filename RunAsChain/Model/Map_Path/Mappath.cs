using RunAsChain.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunAsChain.Model.Map_Path
{
    public class Mappath : IMapFilePath
    {
        private string _mapFilePath;

        public string MapFilePath
        {
            get { return _mapFilePath; }
            set { _mapFilePath = value; }
        }

        public Mappath(string map)
        {
            _mapFilePath = map; 
        }
    }
}
