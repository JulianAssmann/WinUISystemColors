using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;

namespace SystemColors
{
    class ColorToBrushConverter : Windows.UI.Xaml.Data.IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value == null)
                throw new ArgumentNullException("value");
            if (!value.GetType().Equals(typeof(Windows.UI.Color)))
                throw new ArgumentException("Only Windows.UI.Color is supported");

            var color = value as Color?;
            if (color.HasValue)
                return new Windows.UI.Xaml.Media.SolidColorBrush(color.Value);
            else
                throw new ArgumentException("color has a value of null", "value");
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
