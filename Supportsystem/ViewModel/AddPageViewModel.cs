using System;
using System.Windows;
using System.Windows.Input;

namespace Supportsystem
{
    public class AddPageViewModel : PageViewModelBase
    {
        public AddPageViewModel(IView page)
        {
            page.DataContext = this;

            Machines = ReadWrite.Read("data");


            this.AddMachineCommand = new RelayCommand(AddMachine);
            this.CancelCommand = new RelayCommand(Cancel);
        }


        public MachineCatalogue Machines { get; set; }
        public String Comnumber { get; set; }
        public String Location { get; set; }
        public String Customer { get; set; }


        public AddPageViewModel() { }

        //public MachineCatalogue Machines { get; set; }

        public ICommand AddMachineCommand { get; set; }
        public ICommand CancelCommand { get; set; }


        private void AddMachine()
        {
            if(Machines == null)
            {
                Machines = new MachineCatalogue();
            }

            if(Comnumber != null && Location != null && Customer != null)
            {
                Machines.AddMachine(new Machine(Comnumber, Location, Customer));
                ReadWrite.Write(Machines,"data");
                SetPage(AppPage.Catalogue);
            }


        }


        private void Cancel()
        {
            SetPage(AppPage.Catalogue);
        }
    }
}
