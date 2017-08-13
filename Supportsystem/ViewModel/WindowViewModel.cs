using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Supportsystem
{
    public class WindowViewModel : BaseViewModel
    {
        public AppPage CurrentPage { get; set; }

        public List<Machine> Machines { get; set; }

    }
}
