using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
