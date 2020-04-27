using System.Collections.Generic;

namespace BL
{
	internal interface DelimiterParser
	{
		(List<string> delimiters, string numbers) SplitDelimitersAndNumbers(string numbersString);
	}
}
	