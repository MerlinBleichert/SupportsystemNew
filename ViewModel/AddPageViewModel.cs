using System;
using System.Windows;
using System.Windows.Input;

namespace Supportsystem
{
    public class AddPageViewModel : PageViewModelBase
    {
        public String Comnumber { get; set; }
        public String Location { get; set; }
        public String Customer { get; set; }
        public ICommand AddMachineCommand { get; set; }
        public ICommand CancelCommand { get; set; }

        CatalogueViewModel _cvm;

        public AddPageViewModel(CatalogueViewModel cvm)
        {
            _cvm = cvm;
            this.AddMachineCommand = new RelayCommand(AddMachine);
            this.CancelCommand = new RelayCommand(Cancel);
        }




        private void AddMachine()
        {
            if(Comnumber != null && Location != null && Customer != null)
            {
                _cvm.Machines.AddMachine(new Machine(Comnumber, Location, Customer));
                this.ParentWindow.Navigate(_cvm);
            }
        }


        private void Cancel()
        {
            this.ParentWindow.Navigate(_cvm);
        }
    }
}
