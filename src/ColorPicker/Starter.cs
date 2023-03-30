using ColorPicker.Properties;
using System;

namespace ColorPicker
{
    internal class Starter
    {
        [STAThread]
        private static void Main(string[] args)
        {
            _ = new App()
                .AddWireDataContext<WireDataContext>()
                .AddInversionModule<ViewModules>()
                .Run();
        }
    }
}
