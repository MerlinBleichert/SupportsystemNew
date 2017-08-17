using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Supportsystem
{
    public class LoginPageViewModel : PageViewModelBase
    {
        public ICommand OptionPageCommand { get; set; }

        public LoginPageViewModel()
        {
            this.OptionPageCommand = new RelayCommand(ChangeToOptionPage);
        }

        private void ChangeToOptionPage()
        {
            this.ParentWindow.Navigate(typeof(OptionPageViewModel));
        }
    }
}
