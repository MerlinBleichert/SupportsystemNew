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
        CatalogueViewModel _cvm;

        public ICommand Back { get; set; }
        public ICommand GoToFaultDetailPage { get; set; }

        public Machine Machine { get; set; }

        public string Comnumber { get; set; }
        public string Location { get; set; }
        public string Customer { get; set; }

        public List<Fault> Faults { get; set; }

        public MachineDetailViewModel()
        {
        }

        public MachineDetailViewModel(string comnumber, CatalogueViewModel cvm)
        {
            _cvm = cvm;

            Back = new RelayCommand(ChangeToCataloguePage);
            GoToFaultDetailPage = new RelayCommand(ChangeToTicketPage);

            Machine = _cvm.Machines.Machines[comnumber];

            Comnumber = Machine.Comnumber;
            Location = Machine.Location;
            Customer = Machine.Customer;

            Faults = Machine.Faults;

        }



        private void ChangeToTicketPage()
        {
            throw new NotImplementedException();
        }

        private void ChangeToCataloguePage()
        {
            this.ParentWindow.Navigate(typeof(CatalogueViewModel));
        }

    }
}
