using ColorPicker.Foundation.Mvvm;

namespace ColorPicker.Foundation.Wpf
{
    public interface IFlowElement
    {
        IFlowElement SetVm(ObservableObject vm);
        void OnShow();
    }
}
