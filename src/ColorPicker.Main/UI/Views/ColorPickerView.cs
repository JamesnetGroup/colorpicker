using System.Windows;
using System.Windows.Controls;
using ColorPicker.LayoutSupport.Controls;

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
            //IsFixedSize = true;
            //ResizeMode = ResizeMode.NoResize;
            Width = 400;
            Height = 360;

            //Loaded += (s, e) => Topmost = true;
        }
        #endregion
    }
}
