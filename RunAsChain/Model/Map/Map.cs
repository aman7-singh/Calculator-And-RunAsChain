using RunAsChain.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunAsChain.Model.Map
{
    public class Map : IMap
    {
        public string SrcPath { get ; set; }
        public string MapPath { get ; set; }
        public string TrgtPath { get; set ; }
        public ICodeModules BasPaths { get; set; }
        public ITransFormationVariableList VarList { get; set; }
        
       public Map(string mp, string sf, string tp, ICodeModules bl, ITransFormationVariableList tl)
        {
            MapPath = mp;
            SrcPath = sf;
            TrgtPath = tp;
            BasPaths = bl;
            VarList = tl;
        }
    }
}
