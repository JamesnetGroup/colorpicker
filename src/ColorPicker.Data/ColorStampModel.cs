using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ColorPicker.Data
{
    public class ColorStampModel
	{

		public string HexColor { get; set; }
		public byte Red { get; set; }
		public byte Green { get; set; }
		public byte Blue { get; set; }
		public ICommand ColorClickCommand { get; set; }

		public ColorStampModel(ColorStruct rgba, ICommand command)
		{
			HexColor = ConvertColor.Hex(rgba);
			Red = rgba.Red;
			Green = rgba.Green;
			Blue = rgba.Blue;
			ColorClickCommand = command;
		}
	}
}
