using System;
using Windows.UI;

namespace SystemColors
{
    public class ColorToHexStringConverter : Windows.UI.Xaml.Data.IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value == null)
                throw new ArgumentNullException("value");
            if (!value.GetType().Equals(typeof(Windows.UI.Color)))
                throw new ArgumentException("Only Windows.UI.Color is supported");

            var color = value as Color?;
            return color.Value.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}