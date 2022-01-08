using DevNcore.UI.Design.Controls.Primitives;
using System.Windows;

namespace DevNcore.UI.Design.Controls
{
    public class AlphaBIcon : Icon
    {
        static AlphaBIcon()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(AlphaBIcon), new FrameworkPropertyMetadata(typeof(AlphaBIcon)));
        }
    }
}
