using System.Windows;
using ColorPicker.LayoutSupport.Controls;
using ColorPicker.Main.Local.ViewModel;

namespace ColorPicker.Main.UI.Views
{
    public class ColorPickerView : Explorer
    {
        #region DefaultStyleKey

        static ColorPickerView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ColorPickerView), new FrameworkPropertyMetadata(typeof(ColorPickerView)));
        }
        #endregion

        #region Constructor

        public ColorPickerView()
        {
            DataContext = new ColorPickerViewModel();
            Width = 400;
            Height = 360;
        }
        #endregion
    }
}
