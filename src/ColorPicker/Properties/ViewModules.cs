using ColorPicker.Forms.UI.Views;
using ColorPicker.Main.UI.Views;
using Jamesnet.Wpf.Controls;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace ColorPicker.Properties
{
    internal class ViewModules : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IViewable, MainContent>("MainContent");
        }
    }
}
