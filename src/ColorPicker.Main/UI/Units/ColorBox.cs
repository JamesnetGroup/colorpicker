using System.Windows;
using System.Windows.Controls;

namespace ColorPicker.Main.UI.Units
{
    public class ColorBox : Control
    {
        #region DefaultStyleKey

        static ColorBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ColorBox), new FrameworkPropertyMetadata(typeof(ColorBox)));
        }
        #endregion
    }
}
