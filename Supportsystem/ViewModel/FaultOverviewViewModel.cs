using Supportsystem.DataLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Supportsystem
{
    public class FaultOverviewViewModel : PageViewModelBase
    {
        public FaultOverview Faults { get; set; }
 
        public ICommand AllFaultsCommand { get; set; }
        public ICommand UnresolvedFaultsCommand { get; set; }
        public ICommand ResolvedFaultsCommand { get; set; }



        public FaultOverviewViewModel()
        {
            Faults = new FaultOverview();

            this.AllFaultsCommand = new RelayCommand(ShowAllFaults);
            this.UnresolvedFaultsCommand = new RelayCommand(ShowUnsresolvedFaults);
            this.ResolvedFaultsCommand = new RelayCommand(ShowResolvedFaults);
        }

        private void ShowResolvedFaults()
        {
            Faults.ChangeList(FaultOverview.RESOLVED);
        }

        private void ShowUnsresolvedFaults()
        {
            Faults.ChangeList(FaultOverview.UNRESOLVED);
        }

        private void ShowAllFaults()
        {
            Faults.ChangeList(FaultOverview.ALL);
        }
    }
}
