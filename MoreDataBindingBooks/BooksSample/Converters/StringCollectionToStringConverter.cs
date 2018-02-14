using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Data;

namespace BooksSample.Converters
{
    public class StringCollectionToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            IEnumerable<string> names = (IEnumerable<string>)value;
            string separator = parameter.ToString();
            return string.Join(separator, names);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => throw new NotImplementedException();
    }
}
