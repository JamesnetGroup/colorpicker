using System;
using System.Windows;
using ColorPicker.Main.UI.Views;

namespace ColorPicker
{
    public class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            bool? dialogResult = true;

            while (dialogResult == true)
            {
                ShutdownMode = ShutdownMode.OnExplicitShutdown;
                dialogResult = new ColorPickerView().ShowDialog();
            }
            Environment.Exit(0);
        }
    }
}
