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
		public void ThrowsArgumentExceptionWhenTrySubstrack()
		{
			//Assert
			Assert.Throws<ArgumentException>(() => Service.Evaluate("IV+II/V"));
			Assert.Throws<ArgumentException>(() => Service.Evaluate("X/V"));
		}

		[Test]
		public void ThrowsArgumentExceptionWhenInvaldNumber()
		{
			//Assert
			Assert.Throws<ArgumentException>(() => Service.Evaluate("IV+IXI"));
			Assert.Throws<ArgumentException>(() => Service.Evaluate("XVI+VIIII"));
		}

		[Test]
		public void ThrowsArgumentExceptionWhenStringEmptyNullOrWhiteSpase()
		{
			//Assert
			Assert.Throws<ArgumentException>(() => Service.Evaluate(""));
			Assert.Throws<ArgumentException>(() => Service.Evaluate("   "));
			Assert.Throws<ArgumentException>(() => Service.Evaluate(null));
		}

		[Test]
		[TestCase(10, "IV+VI")]
		[TestCase(-2, "IV-VI")]
		[TestCase(3999, "MMM+CM+XC+IX")]
		[TestCase(1942, "M+CM+XL+II")]
		public void ReturnCorrectResultsWithCorrectArguments(int expected, string expression) 
		{
			//Assert
			Assert.AreEqual(expected, Service.Evaluate(expression));
		}
	}
}