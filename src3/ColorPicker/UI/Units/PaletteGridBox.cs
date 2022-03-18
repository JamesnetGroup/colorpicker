using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ColorPicker.UI.Units
{
    public class PaletteGridBox : ListBox
    {
        static PaletteGridBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PaletteGridBox), new FrameworkPropertyMetadata(typeof(PaletteGridBox)));
        }

        public static readonly DependencyProperty SelectionCommandProperty = DependencyProperty.Register("SelectionCommand", typeof(ICommand), typeof(PaletteGridBox));

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new PaletteGridBoxItem();
        }

        protected override void OnSelectionChanged(SelectionChangedEventArgs e)
        {
            base.OnSelectionChanged(e);
            SelectionCommand?.Execute(SelectedItem);
        }

        public ICommand SelectionCommand
        {
            get { return (ICommand)this.GetValue(SelectionCommandProperty); }
            set { this.SetValue(SelectionCommandProperty, value); }
        }
    }
}
