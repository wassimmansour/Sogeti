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

			SimpleGame game = new SimpleGame();
			var actual = game.Play(number);

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void MultiplesOfThree()
		{
			var number = 27;

			var expected = "Fizz";

			SimpleGame game = new SimpleGame();
			var actual = game.Play(number);

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void MultiplesOfFive()
		{
			var number = 25;

			var expected = "Buzz";

			SimpleGame game = new SimpleGame();
			var actual = game.Play(number);

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void MultiplesOfThreeAndFive()
		{
			var number = 15;

			var expected = "Fizz Buzz";

			SimpleGame game = new SimpleGame();
			var actual = game.Play(number);

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void MultiplesOfSeven()
		{
			var number = 14;

			var expected = "Pop";

			SimpleGame game = new SimpleGame();
			var actual = game.Play(number);

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void MultiplesOfThreeAndSeven()
		{
			var number = 21;

			var expected = "Fizz Pop";

			SimpleGame game = new SimpleGame();
			var actual = game.Play(number);

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void MultiplesOfFiveAndSeven()
		{
			var number = 35;

			var expected = "Buzz Pop";

			SimpleGame game = new SimpleGame();
			var actual = game.Play(number);

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void MultiplesOfThreeAndFiveAndSeven()
		{
			var number = 210;

			var expected = "Fizz Buzz Pop";

			SimpleGame game = new SimpleGame();
			var actual = game.Play(number);

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void CustomSubstitution()
		{
			SortedDictionary<int, string> substitutions = new SortedDictionary<int, string>();
			substitutions.Add(2, "Fuzz");

			var number = 210;

			var expected = "Fuzz Fizz Buzz Pop";

			SimpleGame game = new SimpleGame();
			var actual = game.Play(number, substitutions);

			Assert.AreEqual(expected, actual);
		}
	}
}