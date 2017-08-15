using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Supportsystem
{
    public class WindowViewModel : PageViewModelBase
    {

        public WindowViewModel(IView page)
        {
            page.DataContext = this;
            ParentWindow = this;
            SetPage(AppPage.Login);
        }

        public WindowViewModel() { }


        public IView CurrentPage { get; set; }

        



    }
}
