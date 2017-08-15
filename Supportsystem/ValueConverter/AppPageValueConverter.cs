using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supportsystem
{
    public class AppPageValueConverter : BaseValueConverter<AppPageValueConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            IView view;

            switch ((AppPage)value)
            {

                case AppPage.Login:
                    return view = new LoginPage();
                case AppPage.Options:
                    return view = new OptionPage();
                case AppPage.Catalogue:
                    return view = new CataloguePage();
                case AppPage.AddMachine:
                    return view = new AddPage();


                default:
                    Debugger.Break();
                    return null;
            }
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        internal AppPage Convert(AppPage options)
        {
            throw new NotImplementedException();
        }
    }
}
