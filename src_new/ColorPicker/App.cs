using System;
using System.Windows;
using ColorPicker.UI.Views;

namespace ColorPicker
{
    public class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            //bool? dialogResult = true;

            //while (dialogResult == true)
            //{
            //    ShutdownMode = ShutdownMode.OnExplicitShutdown;
            //    dialogResult = new ColorPickerView().ShowDialog();
            //}
            //Environment.Exit(0);

            base.OnStartup(e);
            Resources.MergedDictionaries.Add(new ResourceDictionary { Source = new Uri("/DevNcore.UI.Design.Geometry;component/Themes/Packages.xaml", UriKind.RelativeOrAbsolute) });
            var win = new MainWindow();

            win.ShowDialog();
        }
    }
}
