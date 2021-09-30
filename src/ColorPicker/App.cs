using ColorPicker.Main.Local.ViewModel;
using ColorPicker.Main.UI.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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
				MainWindow main = new()
				{
					DataContext = new MainViewModel()
				};
				_ = main.ShowDialog();
				dialogResult = (bool)main.DialogResult;
			}
		}
    }
}
