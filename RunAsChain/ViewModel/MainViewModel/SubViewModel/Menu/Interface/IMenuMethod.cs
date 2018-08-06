using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunAsChain.ViewModel.MainViewModel.SubViewModel.Menu.Interface
{
    public interface IMenuMethod
    {
        void CreateNewChain(object obj);
        void OpenChain(object obj);
        void SaveChain(object obj);
        void SaveAsChain(object obj);
        void RunChain(object obj);
        void RunAllChain(object obj);
    }
}
