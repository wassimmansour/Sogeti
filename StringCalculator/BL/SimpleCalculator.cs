using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BL
{
	public class SimpleCalculator
	{
		public static int Add(string numbersString)
		{
			if (string.IsNullOrWhiteSpace(numbersString))
			{
				return 0;
			}

			IEnumerable<string> delimiters = GetDelimiters(numbersString);
			
			string strippedNumbersString = GetNumbersString(numbersString);

			IEnumerable<int> numbersArray = GetNumbers(strippedNumbersString, delimiters);

			return numbersArray.Sum();

		}

		private static IEnumerable<string> GetDelimiters(string numbersString)
		{
			List<string> delimiters = new List<string>() { ",", "\n" };

			if (numbersString.Trim().StartsWith("//"))
			{
				var delimitersEnd = numbersString.IndexOf("\n");

				// Strips the "//" at the beginning.
				string delimiterString = numbersString.Substring(2, delimitersEnd - 2);

				if (delimiterString.Contains("["))
				{
					delimiters.AddRange(delimiterString.Substring(1, delimiterString.Length - 2).Split("]["));
				}
				else
				{
					delimiters.Add(delimiterString);
				}
			}

			return delimiters;
		}

		private static string GetNumbersString(string numbersString)
		{
			if (numbersString.Trim().StartsWith("//"))
			{
				var delimitersEnd = numbersString.IndexOf("\n");
				numbersString = numbersString.Substring(delimitersEnd + 1);
			}

			return numbersString;
		}

		private static IEnumerable<int> GetNumbers(string strippedNumbersString, IEnumerable<string> delimiters)
		{
			IEnumerable<string> numbersStrings = new List<string>() { strippedNumbersString };
			foreach (string delimiter in delimiters)
			{
				numbersStrings = numbersStrings.SelectMany(x => x.Split(delimiter));
			}

			List<int> negativeNumbers = new List<int>();

			IEnumerable<int> numbers = numbersStrings.Select(x =>
			{
				int.TryParse(x, out int result);
				if (result < 0)
				{
					negativeNumbers.Add(result);
				}
				if (result > 1000)
				{
					result = 0;
				}
				return result;
			}).ToList();

			if (negativeNumbers.Count() > 0)
			{
				string negatives = negativeNumbers.Select(x => $"{x}").Aggregate((acc, next) => $"{acc}, {next}");
				throw new ArgumentException($"Negatives not allowed. {negatives}");
			}

			return numbers;
		}
	}
}