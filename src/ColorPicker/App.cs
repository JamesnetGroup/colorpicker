using ColorPicker.UI.Views;
using System.Windows;

namespace ColorPicker
{
    public class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var win = new MainWindow();

            win.ShowDialog();
        }
    }
}
