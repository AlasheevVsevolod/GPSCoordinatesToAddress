using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSCoordinatesToAddress.Extensions
{
	static class StringExtensions
	{
		public static string GetTagValue(this string srcString, string tagName)
		{
			int startIndex;
			int stopIndex;

			startIndex = srcString.IndexOf($"<{tagName}>");
			stopIndex = srcString.IndexOf($"</{tagName}>");
			return $@"{srcString.Substring(startIndex + tagName.Length + 2, stopIndex - 2 - startIndex - tagName.Length)}";
		}
	}
}
