namespace ColorPicker.Local.Data
{
    public class ColorStampModel
    {

        public string HexColor { get; set; }
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }

        public ColorStampModel(ColorStruct rgba)
        {
            HexColor = ConvertColor.Hex(rgba);
            Red = rgba.Red;
            Green = rgba.Green;
            Blue = rgba.Blue;
        }
    }
}
