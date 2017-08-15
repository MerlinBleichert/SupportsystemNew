using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Supportsystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window,IView
    {

        private WindowViewModel WVM;

        public MainWindow()
        {
            InitializeComponent();

            WVM = new WindowViewModel(this);

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SetPage(AppPage.Login);

        }

        public void SetPage(AppPage page)
        {
           WVM.CurrentPage = page;
        }
    }
}
