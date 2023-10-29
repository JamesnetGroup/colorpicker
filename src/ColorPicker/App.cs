
using ColorPicker.Forms.UI.Views;
using Jamesnet.Wpf.Controls;
using Prism.Ioc;
using System.Windows;
using Unity;

namespace ColorPicker
{
    public class App : JamesApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<PaletteWindow>();
        }
    }
}
