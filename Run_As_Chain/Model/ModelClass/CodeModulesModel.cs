using Run_As_Chain.Model.ModelInterface;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Run_As_Chain.Model.ModelClass
{
    class CodeModulesModel: ICodeModulesModel
    {
        private ObservableCollection<ICodeModulePathModel> _codemodules;

        public ObservableCollection<ICodeModulePathModel> CodeModules
        {
            get { return _codemodules; }
            //set { _codemodules = value; }
        }

        public void AddCodeModule(ICodeModulePathModel codeModule)
        {
            CodeModules.Add(codeModule);
        }
    }
}
