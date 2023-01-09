using System.Text.RegularExpressions;

namespace RpgMe.Dnd.Extensions
{
	public static partial class RegexExtension
	{
		[GeneratedRegex(@"(?<=[A-Za-z])(?=[A-Z][a-z])|(?<=[a-z0-9])(?=[0-9]?[A-Z])")]
		public static partial Regex PascalCase();
	}
}
