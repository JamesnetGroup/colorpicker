using ColorPicker.Forms.Local.ViewModels;
using ColorPicker.Forms.UI.Views;
using ColorPicker.Main.Local.ViewModels;
using ColorPicker.Main.UI.Views;
using Jamesnet.Wpf.Global.Location;

namespace ColorPicker.Properties
{
    internal class WireDataContext : ViewModelLocationScenario
    {
        protected override void Match(ViewModelLocatorCollection items)
        {
            items.Register<PaletteWindow, ColorPickerViewModel>();
            items.Register<MainContent, MainContentViewModel>();
        }
    }
}
