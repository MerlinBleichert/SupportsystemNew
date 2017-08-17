using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supportsystem.ViewModel
{
    public abstract class WindowViewModelBase : ViewModelBase
    {
        private PageViewModelBase _currentPage;

        public PageViewModelBase CurrentPage
        {
            get { return _currentPage; }
            protected set { _currentPage = value; OnPropertyChanged(); }
        }
        private System.Windows.Window _view;

        public System.Windows.Window View
        {
            get { return _view; }
            protected set { _view = value; OnPropertyChanged(); }
        }
        public WindowViewModelBase(System.Windows.Window view)
        {
            this._view = view;
            this._view.DataContext = this;
        }
        public void Navigate(Type pageType)
        {
            if (typeof(PageViewModelBase).IsAssignableFrom(pageType))
            {
                this.SetPage((PageViewModelBase)Activator.CreateInstance(pageType));
            }
        }
        public void Navigate(PageViewModelBase page)
        {
            if (page != null)
            {
                this.SetPage(page);
            }
        }
        protected void SetPage(PageViewModelBase page)
        {
            page.ParentWindow = this;
            this.CurrentPage = page;
        }
    }
}
