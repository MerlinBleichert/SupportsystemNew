using PropertyChanged;
using Supportsystem.ViewModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Supportsystem
{
    public class ViewModelBase : IViewModel, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                handler(this, e);
            }
        }


        public ViewModelBase()
        {
        }
    }
}
