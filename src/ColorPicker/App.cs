using System;
using System.Windows;
using ColorPicker.Controls.Primitives;
using ColorPicker.Main.Local.ViewModel;
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
                EmptyWindow win = new(new ColorPickerView());
                win.DataContext = new ColorPickerViewModel();
                
                _ = win.ShowDialog();
                dialogResult = win.DialogResult;
            }
            Environment.Exit(0);
        }
    }
}
