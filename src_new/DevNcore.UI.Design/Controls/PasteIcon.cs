using DevNcore.UI.Design.Controls.Primitives;
using System.Windows;

namespace DevNcore.UI.Design.Controls
{
    public class PasteIcon : Icon
    {
        static PasteIcon()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PasteIcon), new FrameworkPropertyMetadata(typeof(PasteIcon)));
        }
    }
}
