using Supportsystem.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Supportsystem
{
    public class MainWindowViewModel : WindowViewModelBase
    {

        public MainWindowViewModel(MainWindow view)
            : base(view)
        {
            this.Navigate(typeof(LoginPageViewModel));
        }

    }
}
