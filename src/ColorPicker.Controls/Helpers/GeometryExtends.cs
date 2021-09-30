using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ColorPicker.Controls.Helpers
{
	public static class GeometryExtends
	{
		#region ToGeometry

		public static Geometry ToGeometry(this string geometryString)
		{
			return Geometry.Parse(geometryString);
		}
		#endregion
	}
}
