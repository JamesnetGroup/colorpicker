using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;
using System.Collections.Generic;
using DevNcore.WPF.Controls;
using DevNcore.UI.Data;

namespace DevNcore.UI.Design.Controls.Primitives
{
    public class Explorer : NcoreWindow
    {
        public static readonly DependencyProperty TitleTemplateProperty = DependencyProperty.Register("TitleTemplate", typeof(DataTemplate), typeof(Explorer), new PropertyMetadata(null));
        public static readonly DependencyProperty SubTitleProperty = DependencyProperty.Register("SubTitle", typeof(object), typeof(Explorer), new PropertyMetadata(null));

        static Explorer()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Explorer), new FrameworkPropertyMetadata(typeof(Explorer)));
        }

        protected bool IsFixedSize;
        private List<ViewOptionModel> Options => ColorConfig.Config.ViewOptions;

        public DataTemplate TitleTemplate
        {
            get => (DataTemplate)GetValue(TitleTemplateProperty);
            set => SetValue(TitleTemplateProperty, value);
        }

        public object SubTitle
        {
            get => GetValue(SubTitleProperty);
            set => SetValue(SubTitleProperty, value);
        }

        public Explorer()
        {
        }

        public override void OnApplyTemplate()
        {
            if (GetTemplateChild("PART_CloseButton") is Button btn)
            {
                btn.Click += (s, e) => Window.GetWindow(this)?.Close();
            }
            if (GetTemplateChild("PART_DragBar") is DraggableBar bar)
            {
                bar.MouseDown += WindowDragMove;
            }
        }

        #region OnShow

        public override void OnShow()
        {
            //if (Options.FirstOrDefault() is ViewOptionModel option)
            //{
            //    var win = Window.GetWindow(this);
            //    //WindowStyle = WindowStyle.None;
            //    //ResizeMode = ResizeMode.CanResize;
            //    //AllowsTransparency = true;

            //    win.Left = option.LocX;
            //    win.Top = option.LocY;

            //    if (!IsFixedSize)
            //    {
            //        Width = option.Width;
            //        Height = option.Height;
            //    }
            //}
            //Show();
        }
        #endregion

        #region OnClosed

        //protected override void OnClosed(EventArgs e)
        //{
        //    base.OnClosed(e);
        //FlowConfig.SaveLocation((int) Left, (int) Top, (int) ActualWidth, (int) ActualHeight);
        //}
        #endregion

        private void WindowDragMove(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                Window.GetWindow(this).DragMove();
            }
        }

        public virtual bool? ShowDialog()
        {
            return new EmptyWindow(this).ShowDialog();
        }
    }
}
