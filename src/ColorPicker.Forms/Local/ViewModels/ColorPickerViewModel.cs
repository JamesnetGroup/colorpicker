using CommunityToolkit.Mvvm.Input;
using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Mvvm;
using Prism.Ioc;
using Prism.Regions;
using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace ColorPicker.Forms.Local.ViewModels
{
    public class ColorPickerViewModel : ObservableBase, IViewLoadable
    {
        private readonly IContainerProvider _containerProvider;
        private readonly IRegionManager _regionManager;

        public ColorPickerViewModel(IContainerProvider containerProvider, IRegionManager regionManager)
        {
            _containerProvider = containerProvider;
            _regionManager = regionManager;
        }
        
        public void OnLoaded(IViewable view)
        {
            IViewable mainContent = _containerProvider.Resolve<IViewable>("MainContent");
            IRegion mainRegion = _regionManager.Regions["MainRegion"];

            if (!mainRegion.Views.Contains(mainContent))
            {
                mainRegion.Add(mainContent);
            }
            mainRegion.Activate(mainContent);
        }
    }
}
