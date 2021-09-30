using ColorPicker.Converter;
using ColorPicker.LayoutSupport.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ColorPicker.Main.UI.Views
{
    public class MainWindow : Explorer
    {
        #region DefaultStyleKey

        static MainWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MainWindow), new FrameworkPropertyMetadata(typeof(MainWindow)));
        }
        #endregion

        #region Constructor

        public MainWindow()
        {
            
        }
        #endregion
    }
}
