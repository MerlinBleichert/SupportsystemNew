using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Supportsystem
{
    public class MachineDetailViewModel : PageViewModelBase
    {
        public CatalogueViewModel _cvm;

        public Boolean IsTextBoxEnabled { get; set; }
        public string ButtonName
        {
            get
            {
                return IsTextBoxEnabled ? "Speichern" : "Ändern"; 
            }

        }

        public ICommand Back { get; set; }
        public ICommand DetailsCommand { get; set; }
        public ICommand AddFaultPage { get; set; }
        public ICommand EnableTextBox { get; set; }

        public Machine Machine { get; set; }

        public MachineDetailViewModel()
        {
        }

        public MachineDetailViewModel(string comnumber, CatalogueViewModel cvm)
        {
            _cvm = cvm;

            Back = new RelayCommand(ChangeToCataloguePage);
            DetailsCommand = new RelayParameterizedCommand(ChangeToFaultDetailPage);
            AddFaultPage = new RelayCommand(ChangeToAddFaultPage);
            EnableTextBox = new RelayCommand(SwitchTextBoxEnabled);

            IsTextBoxEnabled = false;

            Machine = _cvm.Machines.Machines[comnumber];
        }



        private void ChangeToAddFaultPage()
        {
            this.ParentWindow.Navigate(new AddFaultViewModel(this));
        }

        private void ChangeToFaultDetailPage(object parameter)
        {
            this.ParentWindow.Navigate(new FaultDetailViewModel(Machine.FindFault(parameter.ToString()),this,_cvm));
        }

        private void ChangeToCataloguePage()
        {
            this.ParentWindow.Navigate(_cvm);
        }

        private void SwitchTextBoxEnabled()
        {
            if (IsTextBoxEnabled)
            {
                _cvm.Save();
            }
            IsTextBoxEnabled = IsTextBoxEnabled ? false : true;
        }

    }
}
