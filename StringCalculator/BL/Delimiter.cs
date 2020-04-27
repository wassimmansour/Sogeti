using System.Collections.Generic;
using System.Linq;

namespace BL
{
	internal class Delimiter
	{
		private readonly string numbersString;
		internal Delimiter(string numbersString)
		{
			this.numbersString = numbersString;
		}

		internal (List<string> delimiters, string strippedNumbersString) SplitDelimitersAndNumbers()
		{
			List<string> delimiters = new List<string>() { ",", "\n" };
			var strippedNumbersString = numbersString;

			// Custom delimiters.
			if (numbersString.StartsWith("//"))
			{
				var delimitersEnd = numbersString.IndexOf("\n");
				
				strippedNumbersString = numbersString.Substring(delimitersEnd + 1);

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
			}

			return (delimiters, strippedNumbersString);
		}
	}
}
