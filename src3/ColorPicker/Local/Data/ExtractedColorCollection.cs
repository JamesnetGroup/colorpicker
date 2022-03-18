using System.Linq;
using System.Collections.ObjectModel;

namespace ColorPicker.Local.Data
{
    public class ExtractedColorCollection : ObservableCollection<ColorStampModel>
    {
        internal void Insert(ColorStruct rgba)
        {
            if (this.FirstOrDefault(x => x.HexColor == ConvertColor.Hex(rgba)) is null)
            {
                Insert(0, new ColorStampModel(rgba));
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
