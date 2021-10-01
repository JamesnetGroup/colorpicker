﻿using ColorPicker.Controls.Primitives;
using ColorPicker.Data;
using ColorPicker.Foundation.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ColorPicker.LayoutSupport.Controls
{
    public class Explorer : FlowWindow
    {
        #region DependencyProperties

        public static readonly DependencyProperty TitleTemplateProperty = DependencyProperty.Register("TitleTemplate", typeof(DataTemplate), typeof(Explorer), new PropertyMetadata(null));
        public static readonly DependencyProperty SubTitleProperty = DependencyProperty.Register("SubTitle", typeof(object), typeof(Explorer), new PropertyMetadata(null));
        #endregion

        #region DefaultStyleKey

        static Explorer()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Explorer), new FrameworkPropertyMetadata(typeof(Explorer)));
        }
        #endregion

        #region Variables

        protected bool IsFixedSize;
        private List<ViewOptionModel> Options => FlowConfig.Config.ViewOptions;
        #endregion

        #region TitleTemplate

        public DataTemplate TitleTemplate
        {
            get => (DataTemplate)GetValue(TitleTemplateProperty);
            set => SetValue(TitleTemplateProperty, value);
        }
        #endregion

        #region SubTitle

        public object SubTitle
        {
            get => GetValue(SubTitleProperty);
            set => SetValue(SubTitleProperty, value);
        }
        #endregion

        #region Constructor

        public Explorer()
        {
            WindowStyle = WindowStyle.None;
            ResizeMode = ResizeMode.CanResize;
            AllowsTransparency = true;
        }
        #endregion

        #region OnApplyTemplate

        public override void OnApplyTemplate()
        {
            if (GetTemplateChild("PART_CloseButton") is Button btn)
            {
                btn.Click += (s, e) => Close();
            }
            if (GetTemplateChild("PART_DragBar") is DraggableBar bar)
            {
                bar.MouseDown += WindowDragMove;
            }
        }
        #endregion

        #region OnShow

        public override void OnShow()
        {
            if (Options.FirstOrDefault() is ViewOptionModel option)
            {
                Left = option.LocX;
                Top = option.LocY;

                if (!IsFixedSize)
                {
                    Width = option.Width;
                    Height = option.Height;
                }
            }
            Show();
        }
        #endregion

        #region OnClosed

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            FlowConfig.SaveLocation((int)Left, (int)Top, (int)ActualWidth, (int)ActualHeight);
        }
        #endregion

        #region WindowDragMove

        private void WindowDragMove(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                GetWindow(this).DragMove();
            }
        }
        #endregion
    }
}