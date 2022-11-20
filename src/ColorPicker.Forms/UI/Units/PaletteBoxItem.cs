using System.Windows;
using System.Windows.Controls;

namespace ColorPicker.Forms.UI.Units
{
    public class PaletteBoxItem : ListBoxItem
    {
        static PaletteBoxItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PaletteBoxItem), new FrameworkPropertyMetadata(typeof(PaletteBoxItem)));
        }
    }
}
