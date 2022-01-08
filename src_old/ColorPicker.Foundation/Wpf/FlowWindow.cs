using ColorPicker.Foundation.Mvvm;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace ColorPicker.Foundation.Wpf
{
    public abstract class FlowWindow : ContentControl, IFlowElement
    {
        #region Constructor

        public FlowWindow()
        {
            Loaded += FlowWindow_Loaded;
        }
        #endregion

        #region SetVm

        public IFlowElement SetVm(ObservableObject vm)
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

        private void FlowWindow_Loaded(object sender, RoutedEventArgs e)
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
