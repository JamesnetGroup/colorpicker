using DevNcore.UI.Design.Controls.Primitives;
using System.Windows;

namespace DevNcore.UI.Design.Controls
{
    public class EyedropperIcon : Icon
    {
        static EyedropperIcon()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(EyedropperIcon), new FrameworkPropertyMetadata(typeof(EyedropperIcon)));
        }
    }
}
