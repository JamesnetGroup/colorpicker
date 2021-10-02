using System;
using System.Linq;
using System.Collections.ObjectModel;
using ColorPicker.Data;
using ColorPicker.Foundation.Mvvm;

namespace ColorPicker.Main.Local.Collection
{
    public class ExtractedColorCollection : ObservableCollection<ColorStampModel>
    {

        #region Insert

        internal void Insert(ColorStruct rgba)
        {
            if (this.FirstOrDefault(x => x.HexColor == ConvertColor.Hex(rgba)) is null)
            {
                Insert(0, new ColorStampModel(rgba));
            }
            RemoveLast();
        }
        #endregion

        #region RemoveLast

        private void RemoveLast()
        {
            if (Count > 65)
            {
                RemoveAt(Count - 1);
            }
        }
        #endregion
    }
}
