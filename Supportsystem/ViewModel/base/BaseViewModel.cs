using PropertyChanged;
using System.ComponentModel;
using System.Windows;

namespace Supportsystem
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = (sender,e) => { };

        public void ChangePage(AppPage page)
        {
            ((MainWindow)(Application.Current.MainWindow)).SetPage(page);
        }

    }
}
