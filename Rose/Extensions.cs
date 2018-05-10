using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rose
{
	public static class Extensions
	{

		public static int[] AllIndicesOf(this string str, string substr, bool ignoreCase = false)
		{
			if (string.IsNullOrWhiteSpace(str) ||
				string.IsNullOrWhiteSpace(substr))
			{
				throw new ArgumentException("String or substring is not specified.");
			}

			var indexes = new List<int>();
			int index = 0;

			while ((index = str.IndexOf(substr, index, ignoreCase ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal)) != -1)
			{
				indexes.Add(index++);
			}

			return indexes.ToArray();
		}
	}
}
