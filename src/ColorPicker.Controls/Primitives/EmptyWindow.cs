using System.Windows;

namespace ColorPicker.Controls.Primitives
{
    public class EmptyWindow : Window
    {
        public UIElement ContentItem => (UIElement)Content;

        public EmptyWindow(UIElement contentItem)
        {
            Content = contentItem;

            WindowStyle = WindowStyle.None;
            AllowsTransparency = true;
            SizeToContent = SizeToContent.WidthAndHeight;
        }
    }
}
