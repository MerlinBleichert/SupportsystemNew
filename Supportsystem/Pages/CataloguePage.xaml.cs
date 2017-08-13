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
    /// Interaction logic for CataloguePage.xaml
    /// </summary>
    public partial class CataloguePage : Page
    {

        private WindowViewModel WVM;

        public CataloguePage()
        {
            InitializeComponent();

            WVM = new WindowViewModel();

            DataContext = WVM;

            WVM.Machines = new List<Machine>();
            WVM.Machines.Add(new Machine("blabla", "bla", "dudu"));
            WVM.Machines.Add(new Machine("blabla", "bla", "dudu"));
            WVM.Machines.Add(new Machine("blabla", "bla", "dudu"));
            WVM.Machines.Add(new Machine("blabla", "bla", "dudu"));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)(Application.Current.MainWindow)).SetPage(AppPage.AddMachine);
        }
    }
}
