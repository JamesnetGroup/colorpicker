using ColorPicker.Forms.Local.ViewModels;
using ColorPicker.Forms.UI.Views;
using Jamesnet.Wpf.Global.Location;

namespace ColorPicker.Properties
{
    internal class ConnectWireContext : ViewModelLocationScenario
    {
        protected override void SetViewModelLocationScenario(ViewModelLocatorCollection items)
        {
            base.SetViewModelLocationScenario(items);

            items.Register<ColorPickerMain, ColorPickerMainViewModel>();
        }
    }
}
