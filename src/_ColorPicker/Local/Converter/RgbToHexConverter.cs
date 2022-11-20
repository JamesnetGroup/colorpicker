using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace ColorPicker.Local.Converter
{
    public class RgbToHexConverter : MarkupExtension, IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string hex = "";
            int color = int.Parse(value.ToString());

            switch (parameter)
            {
                case "R": hex = $"#FF{color:X2}0000"; break;
                case "G": hex = $"#FF00{color:X2}00"; break;
                case "B": hex = $"#FF0000{color:X2}"; break;
                default:
                    break;
            }

            return hex;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }
    }
}