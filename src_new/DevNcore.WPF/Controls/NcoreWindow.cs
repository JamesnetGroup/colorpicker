using DevNcore.UI.Foundation.Mvvm;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace DevNcore.WPF.Controls
{
    public abstract class NcoreWindow : ContentControl, INcoreElement
    {
        #region Constructor

        public NcoreWindow()
        {
            Loaded += NcoreWindow_Loaded;
        }
        #endregion

        #region SetVm

        public INcoreElement SetVm(ObservableObject vm)
        {
            DataContext = vm;
            return this;
        }
        #endregion

        #region Show

        public abstract void OnShow();
        #endregion

        #region OnDesignerMode

        protected virtual void OnDesignerMode()
        {

        }

        #endregion

        #region Loaded

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
        #endregion
    }
}
