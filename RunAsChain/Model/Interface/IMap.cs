using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunAsChain.Model.Interface
{
    public interface IMap
    {
        ISourceFilePath SrcPath {get;set;}
        IMapFilePath MapPath {get;set;}
        ITargetFilePath TrgtPath {get;set;}
        ICodeModules BasPaths {get;set; }
        ITransFormationVariableList VarList {get;set; }
    }
}
