using Run_As_Chain.Model.ModelClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Run_As_Chain.Model.ModelInterface
{
    public interface IMapModel
    {
        string Sequence { get; }
        string Name { get; }
        string MapFilePath { get; }
        string TargetFilePath { get; }
        string SourceFilePath { get; }
        ITransformationVariablesModel TfVariables { get; }
        ICodeModulesModel CodeModules { get; }
    }
}
