using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Supportsystem
{
    public class FaultDetailViewModel : PageViewModelBase
    {
        private PageViewModelBase _previousViewModel;
        private CatalogueViewModel _cvm = new CatalogueViewModel();

        public Fault Fault { get; set; }

        public ICommand Cancel { get; set; }
        public ICommand ResolvedCommand { get; set; }
        public ICommand MachineDetailCommand { get; set; }

        public FaultDetailViewModel(Fault fault, PageViewModelBase pvmb)
        {
            _previousViewModel = pvmb;

            Fault = fault;

            Cancel = new RelayCommand(GoToLastViewModel);
            ResolvedCommand = new RelayCommand(MarkAsResolved);
            MachineDetailCommand = new RelayCommand(GoToMachineDetail);
        }

        private void GoToLastViewModel()
        {
            this.ParentWindow.Navigate(_previousViewModel);
        }

        private void MarkAsResolved()
        {
            Fault.MarkResolved();
            _cvm.Save();
            GoToLastViewModel();

        }

        private void GoToMachineDetail()
        {
            if(_previousViewModel is MachineDetailViewModel)
            {
                GoToLastViewModel();
            }
            else
            {
                this.ParentWindow.Navigate(new MachineDetailViewModel(_cvm.Machines.FindMachineByTicketID(Fault.ID.ToString()).Comnumber, _cvm));
            }
        }

    }
}
