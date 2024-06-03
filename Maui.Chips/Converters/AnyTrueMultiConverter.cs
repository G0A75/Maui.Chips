using System;
using System.Globalization;
using System.ComponentModel;
using Xamarin.Forms;

namespace Maui.Chips.Converters
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    public class AnyTrueMultiConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values == null || !targetType.IsAssignableFrom(typeof(bool)))
                return BindableProperty.UnsetValue;

            foreach (var value in values)
            {
                if ((value is bool b) && b)
                    return true;
            }
            return false;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
