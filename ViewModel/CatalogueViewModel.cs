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
        public ICommand ExitCommand { get; set; }

        public CatalogueViewModel()
        {
            if(Machines == null) 
                Machines = _rw.Read("data");
            if (Machines == null)
                Machines = new MachineCatalogue();
            this.AddPageCommand = new RelayCommand(ChangeToAddPage);
            this.ExitCommand = new RelayCommand(Exit);
        }






        private void Exit()
        {
            _rw.Write(Machines, "data");
            Application.Current.Shutdown();
        }

        private void ChangeToAddPage()
        {
            this.ParentWindow.Navigate(new AddPageViewModel(this));
        }


    }
}
