using DevNcore.UI.Design.Controls.Primitives;
using System.Windows;

namespace DevNcore.UI.Design.Controls
{
    public class MinimizeIcon : Icon
    {
        static MinimizeIcon()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MinimizeIcon), new FrameworkPropertyMetadata(typeof(MinimizeIcon)));
        }
    }
}
