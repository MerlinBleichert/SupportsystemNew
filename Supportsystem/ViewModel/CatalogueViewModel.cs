using Supportsystem.DataLogic;
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
    public class CatalogueViewModel : PageViewModelBase
    {
        private IReaderWriter<MachineCatalogue> _rw = new MachineCatalogueXmlReaderWriter();

        public MachineCatalogue Machines { get; protected set; }

        public ICommand AddPageCommand { get; set; }
        public ICommand BackCommand { get; set; }
        public ICommand DetailsCommand { get; set; }

        public CatalogueViewModel()
        {
            if(Machines == null) 
                Machines = _rw.Read("data");
            if (Machines == null)
                Machines = new MachineCatalogue();
            this.AddPageCommand = new RelayCommand(ChangeToAddPage);
            this.BackCommand = new RelayCommand(Back);
            this.DetailsCommand = new RelayParameterizedCommand(ChangeToDetailsPage);
        }



        private void Back()
        {
            this.ParentWindow.Navigate(new OptionPageViewModel());
        }

        private void ChangeToAddPage()
        {
            this.ParentWindow.Navigate(new AddPageViewModel(this));
        }

        private void ChangeToDetailsPage(object parameter)
        {
            this.ParentWindow.Navigate(new MachineDetailViewModel(((string)parameter),this));
        }

        public void Save()
        {
            _rw.Write(Machines, "data");
        }


    }
}
