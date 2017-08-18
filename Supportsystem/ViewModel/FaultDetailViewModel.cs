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

        public string Description { get; set; }
        public string ID
        {
            get
            {
                return Fault.ID.ToString();
            }
        } 

        public Fault Fault { get; set; }

        public ICommand Cancel { get; set; }

        public FaultDetailViewModel(Fault fault, MachineDetailViewModel mdvm)
        {
            _mdvm = mdvm;

            Fault = fault;

            Description = Fault.Description;

            Cancel = new RelayCommand(GoBackToMachineDetail);
        }


        private void GoBackToMachineDetail()
        {
            this.ParentWindow.Navigate(_mdvm);
        }

    }
}
