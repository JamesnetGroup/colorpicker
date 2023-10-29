using Jamesnet.Wpf.Controls;
using System.Windows;

namespace ColorPicker.Forms.UI.Views
{
    public class PaletteWindow : DarkThemeWindow
    {
        static PaletteWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PaletteWindow), new FrameworkPropertyMetadata(typeof(PaletteWindow)));
        }

        public PaletteWindow()
        {
            Width = 500;
            Height = 400;
        }
    }
}
