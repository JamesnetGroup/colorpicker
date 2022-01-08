using System.Windows;
using ColorPicker.Local.Mvvm;
using DevNcore.UI.Design.Controls.Primitives;

namespace ColorPicker.UI.Views
{
    public class MainWindow : Explorer
    {
        static MainWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MainWindow), new FrameworkPropertyMetadata(typeof(MainWindow)));
        }

        public MainWindow()
        {
            DataContext = new MainViewModel();
            Width = 400;
            Height = 360;
        }
    }
}
