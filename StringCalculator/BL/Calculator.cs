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

			List<int> numbersArray = GetNumbers(numbersString, new List<string>());

			return numbersArray.Sum();

		}

		private static List<int> GetNumbers(string numbersString, List<string> delimiters)
		{
			// Default delimiters: ',' and '\n'
			if(delimiters.Count() == 0)
			{
				return numbersString.Trim()
						.Split(',')
						.SelectMany(x => x.Split("\n"))
						.Select(x => {
							int.TryParse(x, out int result);
							return result;
						})
						.ToList();
			}
			// Custom delimiter
			else
			{
				return null;
			}
		}
	}
}
