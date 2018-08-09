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
        public ISourceFilePath SrcPath { get ; set; }
        public IMapFilePath MapPath { get ; set; }
        public ITargetFilePath TrgtPath { get; set ; }
        public ICodeModules BasPaths { get; set; }
        public ITransFormationVariableList VarList { get; set; }
        
       public Map(IMapFilePath mp, ISourceFilePath sf, ITargetFilePath tp, ICodeModules bl, ITransFormationVariableList tl)
        {
            MapPath = mp;
            SrcPath = sf;
            TrgtPath = tp;
            BasPaths = bl;
            VarList = tl;
        }
    }
}
