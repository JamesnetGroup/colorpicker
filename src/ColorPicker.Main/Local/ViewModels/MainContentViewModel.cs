using ColorPicker.Support.Local.Config;
using ColorPicker.Support.Local.Models;
using ColorPicker.Support.Local.Worker;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Jamesnet.Wpf.Controls;
using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace ColorPicker.Main.Local.ViewModels
{
    public partial class MainContentViewModel : ObservableObject, IViewLoadable
    {
        private bool _isCaptureActivated;
        private readonly PixelExtractWorker _captureWorker;

        [ObservableProperty]
        private BitmapSource _captureImage;

        [ObservableProperty]
        private bool _isColorCapturing;

        [ObservableProperty]
        private string _currentColor;

        [ObservableProperty]
        private string _reverseColor;

        [ObservableProperty]
        private string _contrastColor;

        [ObservableProperty]
        private int _red;

        [ObservableProperty]

        private int _green;

        [ObservableProperty]
        private int _blue;

        [ObservableProperty]
        public int _alpha = 255;

        public ExtractedColorCollection ExtractedColorSet { get; set; }

        public MainContentViewModel()
        {
            ExtractedColorSet = new ExtractedColorCollection();

            _captureWorker = new PixelExtractWorker
            {
                StartExtract = ExtractColor,
                FinishExtract = () => IsColorCapturing = false
            };

            ColorStruct color = ConvertColor.Parse("#ffffffff");

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

        public void OnLoaded(IViewable view)
        {
            FrameworkElement fe = (FrameworkElement)view;
            Window.GetWindow(fe).Closed += (s, e) =>
            {
                ColorConfig.SaveSpoidColor(CurrentColor);
                Window.GetWindow(fe).Close();
            };
        }

        [RelayCommand]
        private void ColorClick(ColorStampModel color)
        {
            if (color != null)
            {
                ExtractColor(new ColorStruct(color.Red, color.Green, color.Blue, (byte)255));
            }
        }

        [RelayCommand]
        private void Capture(object obj)
        {
            IsColorCapturing = true;
            _captureWorker.Begin();
        }

        [RelayCommand]
        private void Paste(object obj)
        {
            if (obj is "COPY")
            {
                System.Windows.Clipboard.SetText(CurrentColor);
            }
        }

        [RelayCommand]
        private void Minimize(object ui)
        { 
            Window.GetWindow((UIElement)ui).WindowState = WindowState.Minimized;
        }

        private void ExtractColor(ColorStruct rgba)
        {
            _isCaptureActivated = true;

            CurrentColor = ConvertColor.Hex(rgba);
            ReverseColor = ConvertColor.ReverseHex(rgba);
            ContrastColor = ConvertColor.Contrast(rgba);

            Red = rgba.Red;
            Green = rgba.Green;
            Blue = rgba.Blue;

            ExtractedColorSet.Insert(rgba);

            _isCaptureActivated = false;
        }

        private void RgbChanged()
        {
            if (!_isCaptureActivated)
            {
                ExtractColor(new ColorStruct(Red, Green, Blue, Alpha));
            }
        }
    }
}
