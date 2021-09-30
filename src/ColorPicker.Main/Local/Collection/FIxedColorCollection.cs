using ColorPicker.Data;
using ColorPicker.Foundation;
using ColorPicker.Foundation.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorPicker.Main.Local.Collection
{
	public class ExtractedColorCollection : ObservableCollection<ColorStampModel>
	{
		private RelayCommand<ColorStampModel> colorExtracted;

		internal void Insert(ColorStruct rgba, Action<ColorStampModel> command)
		{
			colorExtracted ??= new RelayCommand<ColorStampModel>(command);

			if (this.FirstOrDefault(x => x.HexColor == ConvertColor.Hex(rgba)) is null)
			{
				Insert(0, new ColorStampModel(rgba, colorExtracted));
			}
			RemoveLast();
		}

		private void RemoveLast()
		{
			if (Count > 65)
			{
				RemoveAt(Count - 1);
			}
		}
	}
}
