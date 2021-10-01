using ColorPicker.Controls.Primitives;
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
