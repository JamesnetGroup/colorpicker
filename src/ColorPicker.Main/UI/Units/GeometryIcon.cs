using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ColorPicker.Main.UI.Units
{
    public class GeometryIcon : ContentControl
    {
        public static readonly DependencyProperty FillProperty = DependencyProperty.Register("Fill", typeof(Brush), typeof(GeometryIcon), new PropertyMetadata(null));

        public Brush Fill
        {
            get => (Brush)GetValue(FillProperty);
            set => SetValue(FillProperty, value);
        }

        static GeometryIcon()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(GeometryIcon), new FrameworkPropertyMetadata(typeof(GeometryIcon)));
        }
    }
}
