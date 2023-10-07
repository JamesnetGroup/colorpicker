using System.Collections.ObjectModel;
using System.Linq;

namespace ColorPicker.Support.Local.Models
{
    public class ExtractedColorCollection : ObservableCollection<ColorStampModel>
    {
        public void Insert(ColorStruct rgba)
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
