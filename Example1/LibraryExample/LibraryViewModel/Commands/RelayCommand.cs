
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LibraryViewModel.Commands
{
    internal class RelayCommand : ICommand
    {
        private Action<object> _execute;
        private Func<object, bool> _canExecute;

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            this._execute = execute;
            this._canExecute = canExecute;
        }

        public bool CanExecute(object parameter) => this._canExecute?.Invoke(parameter) ?? true;

        public void Execute(object parameter) => this._execute(parameter);
    }
}
