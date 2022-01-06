using DevNcore.WPF.Controls;
using System.Windows;

namespace DevNcore.UI.Design.Controls.Primitives
{
    public class Icon : NcoreIcon
    {
        static Icon()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Icon), new FrameworkPropertyMetadata(typeof(Icon)));
        }
    }
}
