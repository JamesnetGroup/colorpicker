using System;
using System.Drawing;
using System.Windows.Input;
using ColorPicker.Local.Data;
using Gma.System.MouseKeyHook;

namespace ColorPicker.Local.Worker
{
    public class PixelExtractWorker
    {
        #region Variables

        // 임시 버퍼의 graphic 타입
        private readonly Bitmap buffer = new(1, 1);
        private readonly Graphics buffer_graphics = null;
        private int count = 0;
        private IKeyboardMouseEvents globalMouseHook;
        public Action<ColorStruct> StartExtract = (p) => { };
        public Action FinishExtract = () => { };
        #endregion

        #region Constructor

        public PixelExtractWorker()
        {
            buffer_graphics = Graphics.FromImage(buffer);
        }
        #endregion

        #region Begin

        internal void Begin()
        {
            BeginCapture();
        }
        #endregion

        #region BeginCapture

        private void BeginCapture()
        {
            globalMouseHook = Hook.GlobalEvents();
            globalMouseHook.MouseMove += MainWindow_MouseMove;
            globalMouseHook.MouseDown += GlobalMouseHook_MouseDown;
            Mouse.OverrideCursor = Cursors.Cross;
        }
        #endregion

        #region GlobalMouseHook_MouseDown

        private void GlobalMouseHook_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            CaptureFinished();
            FinishExtract();
        }
        #endregion

        #region CaptureFinished

        private void CaptureFinished()
        {
            globalMouseHook.MouseMove -= MainWindow_MouseMove;
            globalMouseHook.MouseDown -= GlobalMouseHook_MouseDown;
            globalMouseHook.Dispose();
            Mouse.OverrideCursor = null;
        }
        #endregion

        #region MainWindow_MouseMove

        private void MainWindow_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            SetView(e.X, e.Y);
        }
        #endregion

        #region SetView

        private void SetView(int x, int y)
        {
            if (count > 3)
            {
                count = 0;
                ColorStruct color = new(ScreenColor(x, y));
                StartExtract(color);
            }
            else
            {
                count++;
            }
        }
        #endregion

        #region ScreenColor

        private Color ScreenColor(int x, int y)
        {
            // Mouse 위치의 색을 추출한다.
            buffer_graphics.CopyFromScreen(x, y, 0, 0, new Size(1, 1));
            // Pixel 값을 리턴한다.
            return buffer.GetPixel(0, 0);
        }
        #endregion
    }
}
