using System.Linq;
using System.Collections.Generic;

namespace BL
{
	public class SimpleGame
	{
		public static string Play(int number, SortedDictionary<int, string> substitutions = null)
		{
			List<string> result = new List<string>();

			if(substitutions == null)
			{
				substitutions = new SortedDictionary<int, string>();
			}
			
			substitutions.Add(3, "Fizz");
			substitutions.Add(5, "Buzz");
			substitutions.Add(7, "Pop");

			foreach (var substitution in substitutions)
			{
				if(number % substitution.Key == 0)
				{
					result.Add(substitution.Value);
				}
			}

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
