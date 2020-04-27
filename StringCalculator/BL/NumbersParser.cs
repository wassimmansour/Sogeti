using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BL
{
	internal class NumbersParser
	{
		private readonly string numbersString;
		private DelimiterParser delimiterParser;
		
		internal NumbersParser(string numbersString, DelimiterParser delimiterParser)
		{
			this.numbersString = numbersString;
			this.delimiterParser = delimiterParser;
		}

		internal IEnumerable<int> GetNumbers()
		{
			if (string.IsNullOrWhiteSpace(numbersString))
			{
				return new List<int>() { 0 };
			}

			var (delimiters, numbers) = delimiterParser.SplitDelimitersAndNumbers(numbersString);

			var splitNumbers = SplitNumbers(delimiters, numbers);

			return ParseSplitNumbers(splitNumbers);
		}

		private List<string> SplitNumbers(IEnumerable<string> delimiters, string strippedNumbersString)
		{
			List<string> numbersStrings = new List<string>() { strippedNumbersString };
			foreach (string delimiter in delimiters)
			{
				numbersStrings = numbersStrings.SelectMany(x => x.Split(delimiter)).ToList();
			}

			return numbersStrings;
		}

		private List<int> ParseSplitNumbers(IEnumerable<string> splitNumbers)
		{
			List<int> negativeNumbers = new List<int>();
			List<int> numbers = splitNumbers.Select(x =>
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

			HandleNegativeNumbers(negativeNumbers);

			return numbers;
		}

		private void HandleNegativeNumbers(IEnumerable<int> negativeNumbers)
		{
			if (negativeNumbers.Count() > 0)
			{
				string negatives = negativeNumbers.Select(x => $"{x}").Aggregate((acc, next) => $"{acc}, {next}");
				throw new ArgumentException($"Negatives not allowed. {negatives}");
			}
		}
	}
}
