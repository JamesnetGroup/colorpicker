using DevNcore.UI.Foundation.Mvvm;

namespace DevNcore.WPF.Controls
{
    public interface INcoreElement
    {
        INcoreElement SetVm(ObservableObject vm);
        void OnShow();
    }
}
