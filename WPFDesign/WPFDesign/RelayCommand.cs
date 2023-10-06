using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFDesign
{
    public class RelayCommand<T> : CommandBase
    {
        private readonly Action<T> _execute;
        private readonly Predicate<T> _canExecute;

        public RelayCommand(Action<T> execute, Predicate<T> canExecute = null)
        {

            this._execute = execute;
            this._canExecute = canExecute;

        }


        public override bool CanExecute(object parameter)
        {
            return _canExecute?.Invoke((T)parameter) ?? true;

        }

        public override void Execute(object parameter)
        {
            _execute?.Invoke((T)parameter);

        }
    }
}
