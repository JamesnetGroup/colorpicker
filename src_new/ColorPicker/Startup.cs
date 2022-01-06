using System;

namespace ColorPicker
{
    public class Startup
    {
        [STAThread]
        public static void Main(string[] args)
        {
            _ = new App().Run();
        }
    }
}
