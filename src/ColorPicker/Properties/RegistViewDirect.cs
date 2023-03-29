using ColorPicker.Forms.UI.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace ColorPicker.Properties
{
    internal class RegistViewDirect : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            IRegionManager regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("MAIN_REGION", typeof(ColorPickerMain));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }
    }
}
