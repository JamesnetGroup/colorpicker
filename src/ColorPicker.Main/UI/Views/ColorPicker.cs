using System.Windows;
using System.Windows.Controls;
using ColorPicker.LayoutSupport.Controls;

namespace ColorPicker.Main.UI.Views
{
    public class ColorPicker : Explorer
    {
        #region DefaultStyleKey

        static ColorPicker()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ColorPicker), new FrameworkPropertyMetadata(typeof(ColorPicker)));
        }
        #endregion

        #region Constructor

        public ColorPicker()
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
