using DevNcore.UI.Design.Controls.Primitives;
using System.Windows;

namespace DevNcore.UI.Design.Controls
{
    public class CloseIcon : Icon
    {
        static CloseIcon()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CloseIcon), new FrameworkPropertyMetadata(typeof(CloseIcon)));
        }
    }
}
