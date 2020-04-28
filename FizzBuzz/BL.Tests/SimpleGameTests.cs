using NUnit.Framework;
using System.Collections.Generic;

namespace BL.Tests
{
	public class SimpleGameTests
	{
		[Test]
		public void ReturnsSameNumberTest()
		{
			var number = 1;

			var expected = "1";

			var actual = SimpleGame.Play(number);

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void MultiplesOfThree()
		{
			var number = 27;

			var expected = "Fizz";

			var actual = SimpleGame.Play(number);

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void MultiplesOfFive()
		{
			var number = 25;

			var expected = "Buzz";

			var actual = SimpleGame.Play(number);

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void MultiplesOfThreeAndFive()
		{
			var number = 15;

			var expected = "Fizz Buzz";

			var actual = SimpleGame.Play(number);

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void MultiplesOfSeven()
		{
			var number = 14;

			var expected = "Pop";

			var actual = SimpleGame.Play(number);

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void MultiplesOfThreeAndSeven()
		{
			var number = 21;

			var expected = "Fizz Pop";

			var actual = SimpleGame.Play(number);

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void MultiplesOfFiveAndSeven()
		{
			var number = 35;

			var expected = "Buzz Pop";

			var actual = SimpleGame.Play(number);

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void MultiplesOfThreeAndFiveAndSeven()
		{
			var number = 210;

			var expected = "Fizz Buzz Pop";

			var actual = SimpleGame.Play(number);

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void CustomSubstitution()
		{
			string substitutionsString = "2:Fuzz";

			var number = 210;

			var expected = "Fuzz Fizz Buzz Pop";

			var actual = SimpleGame.Play(number, substitutionsString);

			Assert.AreEqual(expected, actual);
		}
	}
}