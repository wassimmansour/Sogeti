using NUnit.Framework;
using BL;

namespace StringCalculator.Tests
{
	public class CalculatorTest
	{
		[Test]
		public void SimpleAdd()
		{
			string numbers = "5,3";
			int expected = 8;

			int actual = Calculator.Add(numbers);

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void EmptyStringAdd()
		{
			string numbers = "";
			int expected = 0;

			int actual = Calculator.Add(numbers);

			Assert.AreEqual(expected, actual);
		}
	}
}