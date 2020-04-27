using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
	internal class CustomDelimiterParserImp : DelimiterParser
	{
		(List<string> delimiters, string numbers) DelimiterParser.SplitDelimitersAndNumbers(string numbersString)
		{
			List<string> delimiters = new List<string>() { ",", "\n" };

			var delimitersEnd = numbersString.IndexOf("\n");

			var numbers = numbersString.Substring(delimitersEnd + 1);

			// Strips the "//" at the beginning.
			string delimiterString = numbersString.Substring(2, delimitersEnd - 2);

			// Multiple delimiters.
			if (delimiterString.Contains("["))
			{
				// Strips the first "[" and the last "]".
				delimiters.AddRange(delimiterString.Substring(1, delimiterString.Length - 2).Split("]["));
			}
			else
			{
				delimiters.Add(delimiterString);
			}

			return (delimiters, numbers);
		}
	}
}
