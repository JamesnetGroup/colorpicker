using System.Windows;
using System.Windows.Controls;

namespace ColorPicker.Main.UI.Units
{
    public class ExtractColorBox : Control
    {
        #region DefaultStyleKey

        static ExtractColorBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ExtractColorBox), new FrameworkPropertyMetadata(typeof(ExtractColorBox)));
        }
        #endregion
    }
}
