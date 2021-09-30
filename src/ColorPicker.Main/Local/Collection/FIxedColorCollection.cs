using ColorPicker.Data;
using ColorPicker.Foundation.Mvvm;
using System;
using System.Collections.ObjectModel;
using System.Linq;

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
