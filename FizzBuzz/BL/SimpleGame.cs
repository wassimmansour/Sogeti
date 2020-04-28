using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace BL
{
	public class SimpleGame
	{
		public string Play(int number)
		{
			List<string> result = new List<string>();
			if (number % 3 == 0)
			{
				result.Add("Fizz");
			}
			if (number % 5 == 0)
			{
				result.Add("Buzz");
			}
			if (number % 7 == 0)
			{
				result.Add("Pop");
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
