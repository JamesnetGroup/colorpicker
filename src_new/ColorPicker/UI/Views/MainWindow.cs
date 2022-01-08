using System.Windows;
using ColorPicker.Local.Mvvm;
using DevNcore.UI.Design.Controls.Primitives;

namespace ColorPicker.UI.Views
{
    public class MainWindow : Explorer
    {
        #region DefaultStyleKey

        static MainWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MainWindow), new FrameworkPropertyMetadata(typeof(MainWindow)));
        }
        #endregion

        #region Constructor

        public MainWindow()
        {
            DataContext = new MainViewModel();
            Width = 400;
            Height = 360;
        }
        #endregion
    }
}
