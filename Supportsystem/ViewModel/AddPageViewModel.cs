using System;
using System.Windows;
using System.Windows.Input;

namespace Supportsystem
{
    public class AddPageViewModel : BaseViewModel
    {
        public AddPageViewModel(IView page)
        {
            page.DataContext = this;

            this.AddMachineCommand = new RelayCommand(AddMachine);
            this.CancelCommand = new RelayCommand(Cancel);
        }



        public String Comnumber { get; set; }
        public String Location { get; set; }
        public String Customer { get; set; }


        public AddPageViewModel() { }

        //public MachineCatalogue Machines { get; set; }

        public ICommand AddMachineCommand { get; set; }
        public ICommand CancelCommand { get; set; }


        private void AddMachine()
        {
            if(CatalogueViewModel.Machines == null)
            {
                CatalogueViewModel.Machines = new MachineCatalogue();
            }

            if(Comnumber != null && Location != null && Customer != null)
            {
                CatalogueViewModel.Machines.AddMachine(new Machine(Comnumber, Location, Customer));
                ((MainWindow)(Application.Current.MainWindow)).SetPage(AppPage.Catalogue);
            }


        }


        private void Cancel()
        {
            ((MainWindow)(Application.Current.MainWindow)).SetPage(AppPage.Catalogue);
        }
    }
}
