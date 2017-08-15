
using System.Windows;
using System.Windows.Controls;


namespace Supportsystem
{
    /// <summary>
    /// Interaction logic for OptionPage.xaml
    /// </summary>
    public partial class OptionPage : Page,IView
    {
        public OptionPage()
        {
            InitializeComponent();
            new OptionPageViewModel(this);
        }

    }
}
