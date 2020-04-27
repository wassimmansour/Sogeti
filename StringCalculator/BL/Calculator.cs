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
			IEnumerable<int> numbersArray = new NumbersParser(numbersString?.Trim()).GetNumbers();

			return numbersArray.Sum();
		}
	}
}
