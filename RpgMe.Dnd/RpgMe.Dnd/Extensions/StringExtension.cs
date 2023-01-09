using System.Text.RegularExpressions;

namespace RpgMe.Dnd.Extensions
{
	public static class StringExtension
	{
		public static string SplitPascalCase(this string str)
		{
			RegexExtension.PascalCase().Replace(str, " ");
			return str;
		}
	}
}
