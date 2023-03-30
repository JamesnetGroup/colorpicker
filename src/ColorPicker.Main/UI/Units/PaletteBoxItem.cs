using System.Windows;
using System.Windows.Controls;

namespace ColorPicker.Main.UI.Units
{
    public class PaletteBoxItem : ListBoxItem
    {
        static PaletteBoxItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PaletteBoxItem), new FrameworkPropertyMetadata(typeof(PaletteBoxItem)));
        }
    }
}
