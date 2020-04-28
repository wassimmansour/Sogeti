using System.Linq;
using System.Collections.Generic;

namespace BL
{
	public class SimpleGame
	{
		public static string Play(int number, string substitutionsInput = "")
		{
			SortedDictionary<int, string> substitutions = ParseSubstitutions(substitutionsInput);

			AddDefaultSubstitutions(substitutions);

			List<string> result = ProcessSubstitutions(number, substitutions);

			return FormatResult(number, result);
		}

		private static SortedDictionary<int, string> ParseSubstitutions(string substitutionsInput)
		{
			SortedDictionary<int, string> substitutions = new SortedDictionary<int, string>();
			if (!string.IsNullOrWhiteSpace(substitutionsInput))
			{
				var substitutionsInputs = substitutionsInput.Split(";");
				foreach (var sub in substitutionsInputs)
				{
					var breakDown = sub.Split(':');
					if (breakDown.Length == 2 && int.TryParse(breakDown[0], out int subKey))
					{
						substitutions.Add(subKey, breakDown[1]);
					}
				}
			}

			return substitutions;
		}

		private static void AddDefaultSubstitutions(SortedDictionary<int, string> substitutions)
		{
			substitutions.Add(3, "Fizz");
			substitutions.Add(5, "Buzz");
			substitutions.Add(7, "Pop");
		}

		private static List<string> ProcessSubstitutions(int number, SortedDictionary<int, string> substitutions)
		{
			List<string> result = new List<string>();
			foreach (var substitution in substitutions)
			{
				if (number % substitution.Key == 0)
				{
					result.Add(substitution.Value);
				}
			}

			return result;
		}

		private static string FormatResult(int number, List<string> result)
		{
			if (result.Count() > 0)
			{
				return result.Aggregate((acc, next) => $"{acc} {next}");
			}
			else
			{
				return number.ToString();
			}
		}
	}
}
