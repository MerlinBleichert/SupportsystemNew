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
        public FaultOverview Faults { get; set; }
 
        public ICommand AllFaultsCommand { get; set; }
        public ICommand UnresolvedFaultsCommand { get; set; }
        public ICommand ResolvedFaultsCommand { get; set; }
        public ICommand BackCommand { get; set; }
        public ICommand MachineCommand { get; set; }

        private CatalogueViewModel _cvm;



        public FaultOverviewViewModel(CatalogueViewModel cvm)
        {
            Faults = new FaultOverview();

            _cvm = cvm;

            this.AllFaultsCommand = new RelayCommand(ShowAllFaults);
            this.UnresolvedFaultsCommand = new RelayCommand(ShowUnsresolvedFaults);
            this.ResolvedFaultsCommand = new RelayCommand(ShowResolvedFaults);
            this.BackCommand = new RelayCommand(Back);
            this.MachineCommand = new RelayParameterizedCommand(GoToFaultDetail);
        }

        private void GoToFaultDetail(object parameter)
        {
            this.ParentWindow.Navigate(new FaultDetailViewModel(Faults.FindFault(parameter.ToString()), new MachineDetailViewModel()));
        }

        private void Back()
        {
            this.ParentWindow.Navigate(typeof(OptionPageViewModel));
        }

        private void ShowResolvedFaults()
        {
            Faults.ChangeList(FaultOverview.RESOLVED);
            OnPropertyChanged("Faults");
        }

        private void ShowUnsresolvedFaults()
        {
            Faults.ChangeList(FaultOverview.UNRESOLVED);
            OnPropertyChanged("Faults");

        }

        private void ShowAllFaults()
        {
            Faults.ChangeList(FaultOverview.ALL);
        }
    }
}
