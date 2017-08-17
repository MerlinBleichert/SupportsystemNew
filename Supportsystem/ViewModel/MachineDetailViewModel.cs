using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Supportsystem
{
    public class MachineDetailViewModel : PageViewModelBase
    {
        public MachineDetailViewModel(IView page)
        {
            page.DataContext = this;

           // this.OptionPageCommand = new RelayCommand(ChangeToOptionPage);
        }



        public MachineDetailViewModel() { }

        //public ICommand OptionPageCommand { get; set; }

        private void ChangeToOptionPage()
        {
            //SetPage(AppPage.Options);
        }

    }
}
