using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ColorPicker.Main.UI.Units
{
    public class PaletteGridBox : ListBox
    {
        #region DefaultStyleKey

        static PaletteGridBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PaletteGridBox), new FrameworkPropertyMetadata(typeof(PaletteGridBox)));
        }
        #endregion

        #region DependencyProperty

        public static readonly DependencyProperty SelectionCommandProperty =
            DependencyProperty.Register("SelectionCommand",
                typeof(ICommand),
                typeof(PaletteGridBox));
        #endregion  

        #region GetContainerForItemOverride

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new PaletteGridBoxItem();
        }
        #endregion

        #region OnSelectionChanged

        protected override void OnSelectionChanged(SelectionChangedEventArgs e)
        {
            base.OnSelectionChanged(e);
            SelectionCommand?.Execute(SelectedItem);
        }
        #endregion

        #region SelectionChanged

        public ICommand SelectionCommand
        {
            get { return (ICommand)this.GetValue(SelectionCommandProperty); }
            set { this.SetValue(SelectionCommandProperty, value); }
        }
        #endregion
    }
}
