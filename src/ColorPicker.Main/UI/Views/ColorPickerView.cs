using System.Windows;
using ColorPicker.Controls.Primitives;
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
            //IsFixedSize = true;
            //ResizeMode = ResizeMode.NoResize;
            Width = 400;
            Height = 360;

            //Loaded += (s, e) => Topmost = true;
        }

        public bool? ShowDialog()
        {
            DataContext = new ColorPickerViewModel();
            return new EmptyWindow(this).ShowDialog();
        }
    }
        #endregion
    }
}
