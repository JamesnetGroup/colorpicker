using System.Windows;
using ColorPicker.LayoutSupport.Controls;

namespace ColorPicker.Main.UI.Views
{
    public class ColorSpoid : Explorer
    {
        #region DefaultStyleKey

        static ColorSpoid()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ColorSpoid), new FrameworkPropertyMetadata(typeof(ColorSpoid)));
        }
        #endregion

        #region Constructor

        public ColorSpoid()
        {
            IsFixedSize = true;
            ResizeMode = ResizeMode.NoResize;
            Width = 400;
            Height = 360;

            Loaded += (s, e) => Topmost = true;
        }
        #endregion
    }
}
