using Jamesnet.Wpf.Controls;
using System.Windows;

namespace ColorPicker.Forms.UI.Views
{
    public class ColorPickerMain : JamesContent
    {
        static ColorPickerMain()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ColorPickerMain), new FrameworkPropertyMetadata(typeof(ColorPickerMain)));
        }
    }
}
