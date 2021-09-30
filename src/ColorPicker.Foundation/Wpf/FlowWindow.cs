using ColorPicker.Data;
using ColorPicker.Foundation.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ColorPicker.Foundation.Wpf
{
	public abstract class FlowWindow : Window, IFlowElement
	{
		#region Constructor

		public FlowWindow()
		{
			Loaded += FlowWindow_Loaded;
		}
		#endregion

		#region UseMvvm

		public IFlowElement UseViewModel(ObservableObject vm)
		{
			DataContext = vm;
			return this;
		}
		#endregion

		#region Show

		public abstract void OnShow(MenuModel menu);
		#endregion

		#region OnDesignerMode

		protected virtual void OnDesignerMode()
		{

		}

		#endregion

		#region Loaded

		private void FlowWindow_Loaded(object sender, RoutedEventArgs e)
		{
			if (DesignerProperties.GetIsInDesignMode(this))
			{
				OnDesignerMode();
			}

			if (DataContext is ObservableObject vm)
			{
				vm.ViewRegister(this);
			}
		}
		#endregion
	}
}
