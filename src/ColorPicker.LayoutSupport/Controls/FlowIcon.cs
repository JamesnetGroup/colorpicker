using ColorPicker.Controls.Primitives;
using ColorPicker.Converter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ColorPicker.LayoutSupport.Controls
{
	public class FlowIcon : Icon
	{
		static FlowIcon()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(FlowIcon), new FrameworkPropertyMetadata(typeof(FlowIcon)));
		}
	}
}
