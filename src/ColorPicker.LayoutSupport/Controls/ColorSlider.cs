using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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

        public ColorSlider()
        {
            Loaded += ColorSlider_Loaded;    
        }

        private void ColorSlider_Loaded(object sender, RoutedEventArgs e)
        {
            Thumb thumb = (this.Template.FindName("PART_Track", this) as Track).Thumb;
            thumb.MouseEnter += new MouseEventHandler(thumb_MouseEnter);
        }

        private void thumb_MouseEnter(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed
                && e.MouseDevice.Captured == null)
            {
                // the left button is pressed on mouse enter
                // but the mouse isn't captured, so the thumb
                // must have been moved under the mouse in response
                // to a click on the track.
                // Generate a MouseLeftButtonDown event.

                MouseButtonEventArgs args = new MouseButtonEventArgs(e.MouseDevice, e.Timestamp, MouseButton.Left);
                args.RoutedEvent = MouseLeftButtonDownEvent;
                (sender as Thumb).RaiseEvent(args);
            }
        }
    }
}
