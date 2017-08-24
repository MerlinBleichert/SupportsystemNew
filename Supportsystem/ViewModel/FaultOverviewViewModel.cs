using Supportsystem.DataLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Supportsystem
{
    public class FaultOverviewViewModel : PageViewModelBase
    {
        public FaultOverview FaultOverview { get; set; }
        public List<Fault> Faults { get; set; }
 
        public ICommand AllFaultsCommand { get; set; }
        public ICommand UnresolvedFaultsCommand { get; set; }
        public ICommand ResolvedFaultsCommand { get; set; }
        public ICommand BackCommand { get; set; }
        public ICommand MachineCommand { get; set; }

        private CatalogueViewModel _cvm;



        public FaultOverviewViewModel(CatalogueViewModel cvm)
        {
            FaultOverview = new FaultOverview(cvm.Machines);

            _cvm = cvm;

            this.AllFaultsCommand = new RelayCommand(ShowAllFaults);
            this.UnresolvedFaultsCommand = new RelayCommand(ShowUnresolvedFaults);
            this.ResolvedFaultsCommand = new RelayCommand(ShowResolvedFaults);
            this.BackCommand = new RelayCommand(Back);
            this.MachineCommand = new RelayParameterizedCommand(GoToFaultDetail);

            ShowUnresolvedFaults();
        }

        private void GoToFaultDetail(object parameter)
        {
            int faultID = -1;
            if (Int32.TryParse(parameter.ToString(), out faultID))
                this.ParentWindow.Navigate(new FaultDetailViewModel(FaultOverview.FindFault(faultID), this,_cvm));
        }

        private void Back()
        {
            this.ParentWindow.Navigate(typeof(OptionPageViewModel));
        }

        private void ShowResolvedFaults()
        {
            Faults = FaultOverview.GetResolvedFaults();
        }

        private void ShowUnresolvedFaults()
        {
            Faults = FaultOverview.GetUnresolvedFaults();
        }

        private void ShowAllFaults()
        {
            Faults = FaultOverview.GetAllFaults();
        }
    }
}
