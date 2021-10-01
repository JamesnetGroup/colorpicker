using System;
using System.Windows;
using ColorPicker.Main.UI.Views;
using ColorPicker.Main.Local.ViewModel;


namespace ColorPicker
{
    public class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            bool dialogResult = true;

            while (dialogResult)
            {
                ShutdownMode = ShutdownMode.OnExplicitShutdown;
                ColorSpoid main = new()
                {
                    DataContext = new ColorSpoidViewModel()
                };
                _ = main.ShowDialog();
                dialogResult = (bool)main.DialogResult;
            }
            Environment.Exit(0);
        }
    }
}
