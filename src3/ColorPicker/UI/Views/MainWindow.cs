using ColorPicker.Local.ViewModel;
using System.Windows;

namespace ColorPicker.UI.Views
{
    public class MainWindow : Window
    {
        #region DefaultStyleKey

        static MainWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MainWindow), new FrameworkPropertyMetadata(typeof(MainWindow)));
        }
        #endregion

        public MainWindow()
        {
            DataContext = new MainViewModel();
            Topmost = true;
            Title = "DevNcore ColorPicker";
            Width = 400;
            Height = 360;
        }
    }
}
