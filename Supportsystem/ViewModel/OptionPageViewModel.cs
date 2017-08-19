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
        public ICommand FaultOverviewPageCommand { get; set; }

        private CatalogueViewModel _cvm = new CatalogueViewModel();

        public OptionPageViewModel()
        {
            this.CataloguePageCommand = new RelayCommand(ChangeToCataloguePage);
            this.FaultOverviewPageCommand = new RelayCommand(ChangeToFaultOverviewPage);
        }



        private void ChangeToFaultOverviewPage()
        {
            this.ParentWindow.Navigate(new FaultOverviewViewModel(_cvm));
        }

        private void ChangeToCataloguePage()
        {
            this.ParentWindow.Navigate(_cvm);
        }

    }
}
