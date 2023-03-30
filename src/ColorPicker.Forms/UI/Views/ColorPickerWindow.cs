using Jamesnet.Wpf.Controls;
using System.Windows;

namespace ColorPicker.Forms.UI.Views
{
    public class ColorPickerWindow : JamesWindow
    {
        static ColorPickerWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ColorPickerWindow), new FrameworkPropertyMetadata(typeof(ColorPickerWindow)));
        }

        public ColorPickerWindow()
        {
            Width = 500;
            Height = 400;
        }
    }
}
