using System.Windows;
using ColorPicker.Controls.Primitives;

namespace ColorPicker.LayoutSupport.Controls
{
    public class FlowIcon : Icon
    {
        #region DefaultStyleKey

        static FlowIcon()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FlowIcon), new FrameworkPropertyMetadata(typeof(FlowIcon)));
        }
        #endregion
    }
}
