using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supportsystem
{
    public class DictionaryValueConverter : BaseValueConverter<DictionaryValueConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            List<Machine> machines = new List<Machine>();
            foreach(KeyValuePair<string,Machine> entry in (Dictionary<string,Machine>)value)
            {
                machines.Add(entry.Value);
                
            }

            return machines;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
