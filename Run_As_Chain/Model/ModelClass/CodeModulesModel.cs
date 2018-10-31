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
        private XmlEnum _element;
        private ObservableCollection<ICodeModulePathModel> _codemodules = new ObservableCollection<ICodeModulePathModel>();

        public ObservableCollection<ICodeModulePathModel> CodeModules
        {
            get { return _codemodules; }
            //set { _codemodules = value; }
        }
        public CodeModulesModel(XmlEnum element)
        {
            _element = element;
        }
        public void AddCodeModule(ICodeModulePathModel codeModule)
        {
            CodeModules.Add(codeModule);
        }
    }
}
