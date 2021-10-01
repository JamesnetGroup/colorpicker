using System.Windows;
using System.Windows.Media;
using System.Windows.Controls;
using ColorPicker.Data;
using ColorPicker.Controls.Helpers;


namespace ColorPicker.Controls.Primitives
{
    public class Icon : ContentControl
    {
        #region DependencyProperties

        public static readonly DependencyProperty FillProperty = DependencyProperty.Register("Fill", typeof(Brush), typeof(Icon), new PropertyMetadata(Brushes.White));
        public static readonly DependencyProperty IconTypeProperty = DependencyProperty.Register("IconType", typeof(GeoIcon), typeof(Icon), new PropertyMetadata(GeoIcon.None, IconTypePropertyChanged));
        public static readonly DependencyProperty DataProperty = DependencyProperty.Register("Data", typeof(Geometry), typeof(Icon), new PropertyMetadata(null));
        #endregion

        #region Fill

        public Brush Fill
        {
            get => (Brush)GetValue(FillProperty);
            set => SetValue(FillProperty, value);
        }
        #endregion

        #region IconType

        public GeoIcon IconType
        {
            get => (GeoIcon)GetValue(IconTypeProperty);
            set => SetValue(IconTypeProperty, value);
        }
        #endregion

        #region Data

        public Geometry Data
        {
            get => (Geometry)GetValue(DataProperty);
            set => SetValue(DataProperty, value);
        }
        #endregion

        #region IconTypePropertyChanged

        private static void IconTypePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            Icon icon = (Icon)d;

            switch ((GeoIcon)e.NewValue)
            {
                case GeoIcon.Close: icon.Data = IconData.CLOSE.ToGeometry(); break;
                case GeoIcon.Minimize: icon.Data = IconData.MINIMIZE.ToGeometry(); break;
                case GeoIcon.EyedropperVariant: icon.Data = IconData.EYEDROPPER_VARIANT.ToGeometry(); break;
                case GeoIcon.ContentPaste: icon.Data = IconData.CONTENTPASTE.ToGeometry(); break;
                case GeoIcon.AlphaR: icon.Data = IconData.ALPHA_R.ToGeometry(); break;
                case GeoIcon.AlphaG: icon.Data = IconData.ALPHA_G.ToGeometry(); break;
                case GeoIcon.AlphaB: icon.Data = IconData.ALPHA_B.ToGeometry(); break;
                case GeoIcon.None:
                    break;
                default:
                    break;
            }
        }
        #endregion
    }
}




