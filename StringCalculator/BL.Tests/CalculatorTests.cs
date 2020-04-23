using NUnit.Framework;

namespace BL.Tests
{
	public class CalculatorTests
	{
		[Test]
		public void SimpleAdd()
		{
			string numbers = "1,3";

			int expected = 4;

			int actual = Calculator.Add(numbers);

			Assert.AreEqual(expected, actual);
		}
	}
}