using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ColorPicker.LayoutSupport.Controls
{
    public class ColorSlider : Slider
    {
        #region DefaultStyleKey

        static ColorSlider()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ColorSlider), new FrameworkPropertyMetadata(typeof(ColorSlider)));
        }
        #endregion

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                var slider = this;
                Point position = e.GetPosition(slider);
                double d = 1.0d / slider.ActualWidth * position.X;
                var p = slider.Maximum * d;
                slider.Value = p;
            }
        }
    }
}
