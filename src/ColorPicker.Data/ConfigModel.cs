using System.Collections.Generic;

namespace ColorPicker.Data
{
    public class ConfigModel
	{
		public ThemeType Theme { get; set; }
		public LanguageType Language { get; set; }
		public List<ViewOptionModel> ViewOptions { get; set; }
		public string SpoidColor { get; set; } = "#FFFFFFFF";

		public ConfigModel()
		{
			ViewOptions = new List<ViewOptionModel>();
		}
	}
}
