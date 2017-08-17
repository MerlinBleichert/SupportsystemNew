using Supportsystem.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supportsystem
{
    public abstract class PageViewModelBase : ViewModelBase
    {
        public WindowViewModelBase ParentWindow { get; set; }
        public PageViewModelBase()
        {

        }

    }
}
