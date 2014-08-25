using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestBindingWithConverter.DataModels;

namespace TestBindingWithConverter.Converters
{
    public class IntToOpacityConverter : System.Windows.Data.IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            double opacity = 1;
            Car c = value as Car;
            
            if (c != null)
            {
                if (c.Id == 5)
                {
                    opacity = 0.3;
                }
                System.Diagnostics.Debug.WriteLine("[IntToOpacityConverter] \t" + "Car Company: " + c.Company + ", Opacity: " +opacity);
            }

            return opacity;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            // One-Way conversion!
            return null;
        }
    }
}
