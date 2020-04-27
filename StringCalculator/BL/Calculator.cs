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
			DelimiterParserFactory factory;
			if (numbersString?.StartsWith("//") ?? false)
			{
				factory = new CustomDelimiterParserFactory();
			}
			else
			{
				factory = new DefaultDelimiterParserFactory();
			}

			IEnumerable<int> numbersArray = new NumbersParser(numbersString?.Trim(), factory).GetNumbers();

			return numbersArray.Sum();
		}
	}
}
