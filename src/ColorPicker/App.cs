using System;
using System.Windows;
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
                Main.UI.Views.ColorPicker main = new();
                MainWindow win = new MainWindow();
                win.WindowStyle = WindowStyle.None;
                win.AllowsTransparency = true;
                win.SizeToContent = SizeToContent.WidthAndHeight;

                win.Content = main;
                    main.DataContext = new ColorPickerViewModel();
                
                _ = win.ShowDialog();
                dialogResult = win.DialogResult;
            }
            Environment.Exit(0);
        }
    }
}
