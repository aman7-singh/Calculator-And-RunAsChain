using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Calculator.ViewModel.Command
{
    public class RelayCommand : ICommand
    {
        //public event EventHandler CanExecuteChanged;
        ///<summary>
        ///Occurs when changes occur that affect whether or not the command should execute.
        ///</summary>
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        readonly Action<object> _execute;
        readonly Predicate<object> _canExecute;
        public bool CanExecute(object parameter)
        {
            return _canExecute==null?true:_canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            _execute.Invoke(parameter);
        }
        public RelayCommand(Action<object> action):this(action,null)
        {

        }
        public RelayCommand(Action<object> action, Predicate<object> predicate)
        {
            if(action !=null)
            {
                _execute = action;
                _canExecute = predicate;
            }
            else
            {
                throw new NotImplementedException("action");
            }
        }
    }
}
