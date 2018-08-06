using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RunAsChain.ViewModel.Command
{
    public class RelayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        Action<object> _execute;
        Predicate<object> _canExecute;
        //public event EventHandler CanExecuteChanged
        //{
        //    add { CommandManager.RequerySuggested += value; }
        //    remove { CommandManager.RequerySuggested -= value; }
        //}
        public RelayCommand(Action<object> action):this(action,null)
        {

        }

        public RelayCommand(Action<object> action, Predicate<Object>predicate )
        {
            if (action != null)
            {
                _execute = action;
                _canExecute = predicate;
            }
        }

        public bool CanExecute(object parameter)
        {
            return  _canExecute == null ? true : _canExecute(parameter);            
        }

        public void Execute(object parameter)
        {
            _execute.Invoke(parameter);
        }
    }
}
