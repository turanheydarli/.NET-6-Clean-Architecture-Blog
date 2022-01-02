using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turan.Shared.Extensions
{
	public static class EnumExtentions
	{
		public static int ToInt(this Enum @enum)
		{
			return Convert.ToInt32(@enum);
		}
	}
}
