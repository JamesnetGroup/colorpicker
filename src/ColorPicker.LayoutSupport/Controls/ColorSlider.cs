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
                ColorSlider? slider = this;
                Point position = e.GetPosition(slider);
                double d = 1.0d / slider.ActualWidth * position.X;
                double p = slider.Maximum * d;
                slider.Value = p;
            }
        }
    }
}
