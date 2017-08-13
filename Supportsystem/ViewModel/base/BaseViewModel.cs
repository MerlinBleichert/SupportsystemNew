using PropertyChanged;
using System.ComponentModel;

namespace Supportsystem
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = (sender,e) => { };
    }
}
