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
        Action<object> _method;
        Predicate<object> _predicate;
        public RelayCommand(Action<object> method, Predicate<object> predicate)
        {
            _method = method;
            _predicate = predicate;
            Execute(method);
        }
        public RelayCommand(Action<object> method) : this(method, null)
        { }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return _predicate == null ? true : _predicate(parameter);
        }

        public void Execute(object parameter)
        {
            if (_method != null)
            {
                _method.Invoke(parameter);
            }
        }
    }
}
