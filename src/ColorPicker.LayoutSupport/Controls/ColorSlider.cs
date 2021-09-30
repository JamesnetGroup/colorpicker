using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ColorPicker.LayoutSupport.Controls
{
	public class ColorSlider : Slider
	{
		#region DefaultStyleKey

		static ColorSlider()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(ColorSlider), new FrameworkPropertyMetadata(typeof(ColorSlider)));
		}
		#endregion
	}
}
