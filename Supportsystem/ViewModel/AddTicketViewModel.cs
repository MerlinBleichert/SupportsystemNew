using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Supportsystem
{
    public class AddTicketViewModel : PageViewModelBase
    {
        //public AddTicketViewModel() { }

        public ICommand AddTicketPage { get; set; }

        public AddTicketViewModel()
        {
            AddTicketPage = new RelayCommand(ChangeToAddTicketPage);
        }

        private void ChangeToAddTicketPage()
        {
            //this.ParentWindow.Navigate(new MachineDetailViewModel());
        }
    }
}
