using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Run_As_Chain.Command
{
    public class RelayCommand : ICommand
    {
        Action Method;

        public RelayCommand(Action method)
        {
            Method = method;
            Execute(method);
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (Method != null)
            {
                Method.Invoke();
            }
        }
    }
}
