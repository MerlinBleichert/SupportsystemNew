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
        public ICommand CataloguePageCommand { get; set; }
        public ICommand TicketPageCommand { get; set; }

        public OptionPageViewModel()
        {
            this.CataloguePageCommand = new RelayCommand(ChangeToCataloguePage);
            this.TicketPageCommand = new RelayCommand(ChangeToTicketPage);
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
