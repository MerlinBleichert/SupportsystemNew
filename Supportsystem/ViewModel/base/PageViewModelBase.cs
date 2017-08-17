using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supportsystem
{
    public class PageViewModelBase : BaseViewModel
    {
        public WindowViewModel ParentWindow { get; set; }
        public IView View { get; set; }

        public void SetPage(AppPage page)
        {

            PageViewModelBase PVMB = null;

            switch (page)
            {

                case AppPage.Login:
                    View = new LoginPage();
                    PVMB = new LoginPageViewModel(View);
                    break;
                case AppPage.Options:
                    View = new OptionPage();
                    PVMB = new OptionPageViewModel(View);
                    break;
                case AppPage.Catalogue:
                    View = new CataloguePage();
                    PVMB = new CatalogueViewModel(View);
                    break;
                case AppPage.AddMachine:
                    View = new AddPage();
                    PVMB = new AddPageViewModel(View);
                    break;
                case AppPage.MachineDetail:
                    View = new DetailPage();
                    PVMB = new MachineDetailViewModel(View);
                    break;



                default:
                    break;
            }
            PVMB.ParentWindow = ParentWindow;
            ParentWindow.CurrentPage = View;
        }
    }
}
