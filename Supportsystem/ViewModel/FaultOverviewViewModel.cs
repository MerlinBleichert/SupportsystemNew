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
            FaultOverview = new FaultOverview();

            _cvm = cvm;

            this.AllFaultsCommand = new RelayCommand(ShowAllFaults);
            this.UnresolvedFaultsCommand = new RelayCommand(ShowUnsresolvedFaults);
            this.ResolvedFaultsCommand = new RelayCommand(ShowResolvedFaults);
            this.BackCommand = new RelayCommand(Back);
            this.MachineCommand = new RelayParameterizedCommand(GoToFaultDetail);
        }

        private void GoToFaultDetail(object parameter)
        {
            this.ParentWindow.Navigate(new FaultDetailViewModel(FaultOverview.FindFault(parameter.ToString()),this));
        }

        private void Back()
        {
            this.ParentWindow.Navigate(typeof(OptionPageViewModel));
        }

        private void ShowResolvedFaults()
        {
            FaultOverview.ChangeList(FaultOverview.RESOLVED);
            Faults = FaultOverview.Faults;
        }

        private void ShowUnsresolvedFaults()
        {
            FaultOverview.ChangeList(FaultOverview.UNRESOLVED);
            Faults = FaultOverview.Faults;

        }

        private void ShowAllFaults()
        {
            FaultOverview.ChangeList(FaultOverview.ALL);
            Faults = FaultOverview.Faults;
        }
    }
}
