using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Run_As_Chain.Model.ModelInterface
{
    public interface ICodeModulesModel
    {
        ObservableCollection<ICodeModulePathModel> CodeModules { get; }
    }
}
