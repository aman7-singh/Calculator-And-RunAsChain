using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunAsChain.Model.Interface
{
    public interface IMap
    {
        string SrcPath {get;set;}
        string MapPath {get;set;}
        string TrgtPath {get;set;}
        ICodeModules BasPaths {get;set; }
        ITransFormationVariableList VarList {get;set; }
    }
}
