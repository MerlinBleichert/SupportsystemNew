using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Xml.Serialization;

namespace Supportsystem
{
    public class CatalogueViewModel : BaseViewModel
    {
        public CatalogueViewModel(IView page)
        {
            if(CatalogueViewModel.Machines == null) CatalogueViewModel.Machines = ReadWrite.Read("data");
            page.DataContext = this;

            this.AddPageCommand = new RelayCommand(ChangeToAddPage);
            this.ExitCommand = new RelayCommand(Exit);
        }

 


        public CatalogueViewModel() { }


        public static MachineCatalogue Machines { get; set; }

        public ICommand AddPageCommand { get; set; }
        public ICommand ExitCommand { get; set; }



        private void Exit()
        {
            ReadWrite.Write(Machines, "data");
            Application.Current.Shutdown();
        }

        private void ChangeToAddPage()
        {
            ((MainWindow)(Application.Current.MainWindow)).SetPage(AppPage.AddMachine);
        }


    }
}
