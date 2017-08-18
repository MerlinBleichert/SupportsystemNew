using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Supportsystem
{
    public class AddFaultViewModel : PageViewModelBase
    {
        public MachineDetailViewModel _mdvm;

        public string Description { get; set; }

        public ICommand AddFault { get; set; }
        public ICommand Cancel { get; set; }

        public AddFaultViewModel(MachineDetailViewModel mdvm)
        {
            _mdvm = mdvm;

            AddFault = new RelayCommand(AddFaultToMachine);
            Cancel = new RelayCommand(GoBackToMachineDetail);
        }

        private void GoBackToMachineDetail()
        {
            this.ParentWindow.Navigate(_mdvm);
        }

        private void AddFaultToMachine()
        {
            _mdvm.Machine.AddFault(new Fault(Description));
            this.ParentWindow.Navigate(_mdvm);
        }
    }
}
