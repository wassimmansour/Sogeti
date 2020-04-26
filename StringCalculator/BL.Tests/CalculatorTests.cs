using NUnit.Framework;

namespace BL.Tests
{
	public class CalculatorTests
	{
		[Test]
		[Order(1)]
		public void EmptyString()
		{
			string numbers = "";

			int expected = 0;

			int actual = Calculator.Add(numbers);

			Assert.AreEqual(expected, actual);
		}

		[Test]
		[Order(2)]
		public void SingleNumber()
		{
			string numbers = "24";

			int expected = 24;

			int actual = Calculator.Add(numbers);

			Assert.AreEqual(expected, actual);
		}

		[Test]
		[Order(3)]
		public void MulipleNumbersWithComma()
		{
			string numbers = "11,22,303";

			int expected = 336;

			int actual = Calculator.Add(numbers);

			Assert.AreEqual(expected, actual);
		}

		[Test]
		[Order(4)]
		public void MulipleNumbersWithNewLine()
		{
			string numbers = "11\n22\n303";

			int expected = 336;

			int actual = Calculator.Add(numbers);

			Assert.AreEqual(expected, actual);
		}

		[Test]
		[Order(5)]
		public void MulipleNumbersWithMixedDelimiters()
		{
			string numbers = "11\n22,303";

			int expected = 336;

			int actual = Calculator.Add(numbers);

			Assert.AreEqual(expected, actual);
		}
	}
}