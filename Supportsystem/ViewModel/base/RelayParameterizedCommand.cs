using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Supportsystem
{
    class RelayParameterizedCommand : ICommand
    {

        private Action<object> mAction;

        public RelayParameterizedCommand(Action<object> action)
        {
            mAction = action;
        }

        public event EventHandler CanExecuteChanged = (sender,e) => { };

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            mAction(parameter);
        }
    }
}
