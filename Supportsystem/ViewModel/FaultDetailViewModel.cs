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
        public MachineDetailViewModel _mdvm; 

        public Fault Fault { get; set; }

        public ICommand Cancel { get; set; }
        public ICommand ResolvedCommand { get; set; }

        public FaultDetailViewModel(Fault fault, MachineDetailViewModel mdvm)
        {
            _mdvm = mdvm;

            Fault = fault;

            Cancel = new RelayCommand(GoBackToMachineDetail);
            ResolvedCommand = new RelayCommand(MarkAsResolved);
        }


        private void GoBackToMachineDetail()
        {
            this.ParentWindow.Navigate(_mdvm);
        }

        private void MarkAsResolved()
        {
            Fault.MarkResolved();
            _mdvm._cvm.Save();
            GoBackToMachineDetail();

        }

    }
}
