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
            switch ((AppPage)value)
            {
                case AppPage.Login:
                    return new LoginPage();
                case AppPage.Options:
                    return new OptionPage();
                case AppPage.Catalogue:
                    return new CataloguePage();
                case AppPage.AddMachine:
                    return new AddPage();


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
