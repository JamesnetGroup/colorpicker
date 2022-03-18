using System.Windows;
using System.Windows.Controls;

namespace ColorPicker.UI.Units
{
    public class PaletteGridBoxItem : ListBoxItem
    {
        static PaletteGridBoxItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PaletteGridBoxItem), new FrameworkPropertyMetadata(typeof(PaletteGridBoxItem)));
        }
    }
}
