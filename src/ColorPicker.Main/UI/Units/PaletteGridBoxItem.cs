using System.Windows;
using System.Windows.Controls;

namespace ColorPicker.Main.UI.Units
{
    public class PaletteGridBoxItem : ListBoxItem
    {
        #region DefaultStyleKey

        static PaletteGridBoxItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PaletteGridBoxItem), new FrameworkPropertyMetadata(typeof(PaletteGridBoxItem)));
        }
        #endregion
    }
}
