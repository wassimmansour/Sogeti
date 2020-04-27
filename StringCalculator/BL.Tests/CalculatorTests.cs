using NUnit.Framework;
using System;

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

		[Test]
		[Order(6)]
		public void MulipleNumbersWithOneCustomDelimiter()
		{
			string numbers = "//**\n11**22**303";

			int expected = 336;

			int actual = Calculator.Add(numbers);

			Assert.AreEqual(expected, actual);
		}

		[Test]
		[Order(7)]
		public void MulipleNumbersWithMultipleCustomDelimiters()
		{
			string numbers = "//[**][^^][&&]\n11**22^^303&&123";

			int expected = 459;

			int actual = Calculator.Add(numbers);

			Assert.AreEqual(expected, actual);
		}

		[Test]
		[Order(8)]
		public void MulipleNumbersWithNumbersLargerThan1000()
		{
			string numbers = "//[**][^^]\n11**2200^^3203^^123";

			int expected = 134;

			int actual = Calculator.Add(numbers);

			Assert.AreEqual(expected, actual);
		}

		[Test]
		[Order(9)]
		public void MulipleNumbersWithNegativeNumbers()
		{
			Assert.Throws<ArgumentException>(_MulipleNumbersWithNegativeNumbers, "Negatives not allowed. -22, -44");
		}

		private void _MulipleNumbersWithNegativeNumbers()
		{
			string numbers = "//[**][^^]\n11**-22^^303**-44";

			int actual = Calculator.Add(numbers);
		}
	}
}