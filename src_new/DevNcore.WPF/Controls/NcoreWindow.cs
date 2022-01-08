using DevNcore.UI.Foundation.Mvvm;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace DevNcore.WPF.Controls
{
    public abstract class NcoreWindow : ContentControl, INcoreElement
    {
        public NcoreWindow()
        {
            Loaded += NcoreWindow_Loaded;
        }

        public INcoreElement SetVm(ObservableObject vm)
        {
            DataContext = vm;
            return this;
        }

        public abstract void OnShow();

        protected virtual void OnDesignerMode()
        {

        }

        private void NcoreWindow_Loaded(object sender, RoutedEventArgs e)
        {
            if (DesignerProperties.GetIsInDesignMode(this))
            {
                OnDesignerMode();
            }

            if (DataContext is ObservableObject vm)
            {
                vm.ViewRegister(this);
            }
        }
    }
}
