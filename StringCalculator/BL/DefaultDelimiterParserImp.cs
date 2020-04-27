using System.Collections.Generic;
using System.Linq;

namespace BL
{
	internal class DefaultDelimiterParserImp : DelimiterParser
	{
		(List<string> delimiters, string numbers) DelimiterParser.SplitDelimitersAndNumbers(string numbersString)
		{
			List<string> delimiters = new List<string>() { ",", "\n" };
			return (delimiters, numbersString);
		}
	}
}
