using Run_As_Chain.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Run_As_Chain.ViewModel
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            this.OpenCommand = new RelayCommand(OpenAction);
        }

        public ICommand OpenCommand { get; set; }

        public void OpenAction()
        {

        }
    }
}
