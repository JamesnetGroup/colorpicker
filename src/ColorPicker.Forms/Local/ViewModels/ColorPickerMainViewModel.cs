using ColorPicker.Forms.Local.Config;
using ColorPicker.Forms.Local.Models;
using ColorPicker.Forms.Local.Worker;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Jamesnet.Wpf.Controls;
using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace ColorPicker.Forms.Local.ViewModels
{
    public class ColorPickerMainViewModel : ObservableObject, IViewLoadable
    {
        #region Variables

        private int _red;
        private int _green;
        private int _blue;
        private string _currentColor;
        private string _reverseColor;
        private string _contrastColor;
        private bool _isColorCapturing;

        private BitmapSource _captureImage;

        private bool IsCaptureActivated;
        private FrameworkElement _view;
        private readonly PixelExtractWorker Capture;
        #endregion

        #region Commands

        public ICommand MinimizeCommand { get; set; }
        public ICommand PasteCommand { get; }
        public ICommand CaptureCommand { get; }
        public ICommand ColorClickCommand { get; }
        #endregion

        #region CaptureImage

        public BitmapSource CaptureImage
        {
            get => _captureImage;
            set { _captureImage = value; OnPropertyChanged(); }
        }
        #endregion

        #region IsColorCapturing

        public bool IsColorCapturing
        {
            get => _isColorCapturing;
            set { _isColorCapturing = value; OnPropertyChanged(); }
        }
        #endregion

        #region CurrentColor

        public string CurrentColor
        {
            get => _currentColor;
            set { _currentColor = value; OnPropertyChanged(); }
        }
        #endregion

        #region ReverseColor 

        public string ReverseColor
        {
            get => _reverseColor;
            set { _reverseColor = value; OnPropertyChanged(); }
        }
        #endregion

        #region ContrastColor 

        public string ContrastColor
        {
            get => _contrastColor;
            set { _contrastColor = value; OnPropertyChanged(); }
        }
        #endregion

        #region Red

        public int Red
        {
            get => _red;
            set { _red = value; OnPropertyChanged(); RgbChanged(); }
        }
        #endregion

        #region Green

        public int Green
        {
            get => _green;
            set { _green = value; OnPropertyChanged(); RgbChanged(); }
        }
        #endregion

        #region Blue

        public int Blue
        {
            get => _blue;
            set { _blue = value; OnPropertyChanged(); RgbChanged(); }
        }
        #endregion

        public int Alpha { get; set; } = 255;

        public ExtractedColorCollection ExtractedColorSet { get; set; }

        public ColorPickerMainViewModel()
        {
            ColorClickCommand = new RelayCommand<ColorStampModel>(ColorSelected);
            CaptureCommand = new RelayCommand<object>(BeginCapture);
            PasteCommand = new RelayCommand<object>(Paste);
            MinimizeCommand = new RelayCommand<object>(DoMinimizing);
            ExtractedColorSet = new ExtractedColorCollection();

            Capture = new PixelExtractWorker
            {
                StartExtract = ExtractColor,
                FinishExtract = () => IsColorCapturing = false
            };

            ColorStruct color = ConvertColor.Parse(/*ColorConfig.Config.SpoidColor*/"#ffffffff");

            if (color.Blue < 128)
            {
                _ = color.SetAddBlue(128);
                for (int i = 0; i < 64; i++)
                {
                    ExtractColor(color.SetAddBlue(-2));
                }
            }
            else
            {
                _ = color.SetAddBlue(-128);
                for (int i = 0; i < 64; i++)
                {
                    ExtractColor(color.SetAddBlue(2));
                }
            }
        }
        
        public void OnLoaded(IViewable ele)
        {
            _view = ele.View;
            Window.GetWindow(_view).Closed += Window_Closed;
        }

        #region RgbChanged

        private void RgbChanged()
        {
            if (!IsCaptureActivated)
            {
                ExtractColor(new ColorStruct(Red, Green, Blue, Alpha));
            }
        }
        #endregion

        #region ColorSelected

        private void ColorSelected(ColorStampModel color)
        {
            if (color != null)
            {
                ExtractColor(new ColorStruct(color.Red, color.Green, color.Blue, (byte)255));
            }
        }
        #endregion

        #region BeginCapture

        private void BeginCapture(object obj)
        {
            IsColorCapturing = true;
            Capture.Begin();
        }
        #endregion

        #region ExtractColor

        private void ExtractColor(ColorStruct rgba)
        {
            IsCaptureActivated = true;

            CurrentColor = ConvertColor.Hex(rgba);
            ReverseColor = ConvertColor.ReverseHex(rgba);
            ContrastColor = ConvertColor.Contrast(rgba);

            Red = rgba.Red;
            Green = rgba.Green;
            Blue = rgba.Blue;

            ExtractedColorSet.Insert(rgba);

            IsCaptureActivated = false;
        }
        #endregion

        private void Paste(object obj)
        {
            if (obj is "COPY")
            {
                System.Windows.Clipboard.SetText(CurrentColor);
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            ColorConfig.SaveSpoidColor(CurrentColor);
            Window.GetWindow(_view).Close();
        }

        private void DoMinimizing(object ui)
        {
            Window.GetWindow((UIElement)ui).WindowState = WindowState.Minimized;
        }
    }
}
