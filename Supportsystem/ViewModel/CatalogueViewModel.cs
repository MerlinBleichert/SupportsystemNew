using System;
using System.Windows;
using System.Windows.Input;

namespace Supportsystem
{
    public class CatalogueViewModel : PageViewModelBase
    {
        public CatalogueViewModel(IView page)
        {
            Machines = ReadWrite.Read("data");
            page.DataContext = this;

            this.AddPageCommand = new RelayCommand(ChangeToAddPage);
            this.ExitCommand = new RelayCommand(Exit);
            this.DetailsCommand = new RelayCommand(OpenDetailsWindow);
        }

        public CatalogueViewModel() { }


        public MachineCatalogue Machines { get; set; }

        public ICommand DetailsCommand { get; set; }
        public ICommand AddPageCommand { get; set; }
        public ICommand ExitCommand { get; set; }



        private void Exit()
        {
            ReadWrite.Write(Machines, "data");
            Application.Current.Shutdown();
        }

        private void ChangeToAddPage()
        {
            SetPage(AppPage.AddMachine);
        }

        private void OpenDetailsWindow()
        {
            SetPage(AppPage.MachineDetail);
        }


    }
}
