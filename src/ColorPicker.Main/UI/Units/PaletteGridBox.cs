using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ColorPicker.Main.UI.Units
{
	public class PaletteGridBox : ListBox
	{
		#region DefaultStyleKey

		static PaletteGridBox()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(PaletteGridBox), new FrameworkPropertyMetadata(typeof(PaletteGridBox)));
		}
		#endregion
	}
}
