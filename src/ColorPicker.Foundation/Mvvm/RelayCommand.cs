using System;
using System.Windows.Input;

namespace ColorPicker.Foundation.Mvvm
{
    public class RelayCommand<T> : ICommand
    {
        private readonly Action<T>? _execute;
        private readonly Predicate<T>? _canExecute;

        #region Constructors

        public RelayCommand(Action<T> execute)
            : this(execute, null)
        {
            _execute = null;
            _canExecute = null;
        }
        
        public RelayCommand(Action<T> execute, Predicate<T>? canExecute)
        {
            _execute = execute ?? throw new ArgumentNullException("execute");
            _canExecute = canExecute;
        }
        #endregion

        #region Execute

        public void Execute(object parameter)
        {
            _execute.Invoke((T)parameter);
        }
        #endregion

        #region CanExecute

        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute((T)parameter);
        }
        #endregion

        #region CanExecuteChanged

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        #endregion
    }
}
