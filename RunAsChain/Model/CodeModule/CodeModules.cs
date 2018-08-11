using RunAsChain.Model.Interface;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunAsChain.Model.CodeModule
{
    public class CodeModules:ICodeModules
    {
        private ObservableCollection<ICodeModule> _basFilePathList;

        public CodeModules(ObservableCollection<ICodeModule> basobj)
        {
            this._basFilePathList = basobj;
        }

        public ObservableCollection<ICodeModule> BasFilePathList
        {
            get { return _basFilePathList; }
            set { _basFilePathList = value; }
        }

    }
}
