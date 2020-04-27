using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BL
{
	public class Calculator
	{
		public static int Add(string numbersString)
		{
			if (string.IsNullOrWhiteSpace(numbersString))
			{
				return 0;
			}

			IEnumerable<string> delimiters = GetDelimiters(numbersString);
			string strippedNumbersString = StripNumbersString(numbersString);

			IEnumerable<int> numbersArray = GetNumbers(strippedNumbersString, delimiters);

			return numbersArray.Sum();

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
				if(result < 0)
				{
					negativeNumbers.Add(result);
				}
				if(result > 1000)
				{
					result = 0;
				}
				return result;
			}).ToList();

			if(negativeNumbers.Count() > 0)
			{
				string negatives = negativeNumbers.Select(x => $"{x}").Aggregate((acc, next) => $"{acc}, {next}");
				throw new ArgumentException($"Negatives not allowed. {negatives}");
			}

			return numbers;
		}

		private static IEnumerable<string> GetDelimiters(string numbersString)
		{
			if (numbersString.Trim().StartsWith("//"))
			{
				IEnumerable<char> delimiterCharacters = numbersString.Skip(2)
					.TakeWhile(x => x.ToString() != "\n");

				string delimiterString = new string(delimiterCharacters.ToArray());

				if (delimiterString.Contains("["))
				{
					return new string(delimiterString.Skip(1).SkipLast(1).ToArray()).Split("][").Append(",").Append("\n");
				}
				else
				{
					return new string[] { delimiterString, "," , "\n"};
				}
			}
			else
			{
				return new string[] { ",", "\n" };
			}
		}

		private static string StripNumbersString(string numbersString)
		{
			if (numbersString.Trim().StartsWith("//"))
			{
				IEnumerable<char> numberStringCharacters = numbersString.SkipWhile(x => x.ToString() != "\n").Skip(1);
				numbersString = new string(numberStringCharacters.ToArray());
			}

			return numbersString;
		}
	}
}
