using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace DevNcore.WPF.Controls
{
    public class NcoreIcon : Control
    {
        public static readonly DependencyProperty DataProperty = DependencyProperty.Register("Data", typeof(Geometry), typeof(NcoreIcon), new PropertyMetadata(null));
        public static readonly DependencyProperty FillProperty = DependencyProperty.Register("Fill", typeof(Brush), typeof(NcoreIcon), new PropertyMetadata(null));
        public static readonly DependencyProperty StrokeProperty = DependencyProperty.Register("Stroke", typeof(Brush), typeof(NcoreIcon), new PropertyMetadata(null));
        public static readonly DependencyProperty StrokeThicknessProperty = DependencyProperty.Register("StrokeThickness", typeof(Thickness), typeof(NcoreIcon), new PropertyMetadata(new Thickness(0, 0, 0, 0)));
        public static readonly DependencyProperty CornerRadiusProperty = DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(NcoreIcon), new PropertyMetadata(new CornerRadius(0, 0, 0, 0)));
        public static readonly DependencyProperty GeometryWidthProperty = DependencyProperty.Register("GeometryWidth", typeof(double), typeof(NcoreIcon), new PropertyMetadata(0.0));
        public static readonly DependencyProperty GeometryHeightProperty = DependencyProperty.Register("GeometryHeight", typeof(double), typeof(NcoreIcon), new PropertyMetadata(0.0));

        public Geometry Data
        {
            get => (Geometry)GetValue(DataProperty);
            set => SetValue(DataProperty, value);
        }

        public Brush Fill
        {
            get => (Brush)GetValue(FillProperty);
            set => SetValue(FillProperty, value);
        }

        public Brush Stroke
        {
            get => (Brush)GetValue(StrokeProperty);
            set => SetValue(StrokeProperty, value);
        }

        public Thickness StrokeThickness
        {
            get => (Thickness)GetValue(StrokeThicknessProperty);
            set => SetValue(StrokeThicknessProperty, value);
        }

        public CornerRadius CornerRadius
        {
            get => (CornerRadius)GetValue(CornerRadiusProperty);
            set => SetValue(CornerRadiusProperty, value);
        }

        public double GeometryWidth
        {
            get => (double)GetValue(GeometryWidthProperty);
            set => SetValue(GeometryWidthProperty, value);
        }

        public double GeometryHeight
        {
            get => (double)GetValue(GeometryHeightProperty);
            set => SetValue(GeometryHeightProperty, value);
        }
    }
}
