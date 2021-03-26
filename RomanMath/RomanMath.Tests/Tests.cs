using NUnit.Framework;
using RomanMath.Impl;
using System;

namespace RomanMath.Tests
{
	public class Tests
	{

		[SetUp]
		public void Setup()
		{
		}

		[Test]
		[TestCase("IV+II/V")]
		[TestCase("X/V")]
		public void ThrowsArgumentExceptionWhenTrySubstrack(string argument)
		{
			//Assert
			Assert.Throws<ArgumentException>(() => Service.Evaluate(argument));
		}

		[Test]
		[TestCase("IV+IXI")]
		[TestCase("XVI+VIIII")]
		public void ThrowsArgumentExceptionWhenInvaldNumber(string arument)
		{
			//Assert
			Assert.Throws<ArgumentException>(() => Service.Evaluate(arument));
		}

		[Test]
		[TestCase(null)]
		[TestCase("")]
		[TestCase("   ")]
		public void ThrowsArgumentExceptionWhenStringEmptyNullOrWhiteSpase(string argumet)
		{
			//Assert
			Assert.Throws<ArgumentException>(() => Service.Evaluate(argumet));
		}

		[Test]
		[TestCase(10, "IV+VI")]
		[TestCase(-2, "IV-VI")]
		[TestCase(3999, "MMM+CM+XC+IX")]
		[TestCase(1942, "M+CM+XL+II")]
		[TestCase(2380, "MMM-CM+XL*VII")]
		public void ReturnCorrectResultsWithCorrectArguments(int expected, string expression) 
		{
			//Assert
			Assert.AreEqual(expected, Service.Evaluate(expression));
		}
	}
}