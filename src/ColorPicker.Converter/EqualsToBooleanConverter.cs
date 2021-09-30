using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Markup;

namespace ColorPicker.Converter
{
	public class EqualsToBooleanConverter : MarkupExtension, IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return value.Equals("Transparent");
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
