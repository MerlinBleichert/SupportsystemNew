using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Supportsystem
{
    public class LoginPageViewModel : BaseViewModel
    {
        public LoginPageViewModel(IView page)
        {
            page.DataContext = this;

            this.OptionPageCommand = new RelayCommand(ChangeToOptionPage);
        }



        public LoginPageViewModel() { }

        public ICommand OptionPageCommand { get; set; }

        private void ChangeToOptionPage()
        {
            ((MainWindow)(Application.Current.MainWindow)).SetPage(AppPage.Options);
        }

    }
}
