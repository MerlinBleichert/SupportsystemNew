using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Supportsystem
{
    public class OptionPageViewModel : PageViewModelBase
    {
        public OptionPageViewModel(IView page)
        {
            page.DataContext = this;

            this.CataloguePageCommand = new RelayCommand(ChangeToCataloguePage);
            this.TicketPageCommand = new RelayCommand(ChangeToTicketPage);
        }



        public OptionPageViewModel() { }

        //public MachineCatalogue Machines { get; set; }

        public ICommand CataloguePageCommand { get; set; }
        public ICommand TicketPageCommand { get; set; }


        private void ChangeToTicketPage()
        {
            throw new NotImplementedException();
        }

        private void ChangeToCataloguePage()
        {
            SetPage(AppPage.Catalogue);
        }

    }
}
