using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Rectangle.Impl;

namespace Rectangle.Tests
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void FindRectangleTest()
		{
			//arrange
			List<Point> list = new List<Point>();
			list.Add(new Point() { X = 1, Y = 1 });
			list.Add(new Point() { X = 1, Y = 2 });
			list.Add(new Point() { X = 3, Y = 1 });
			list.Add(new Point() { X = 3, Y = 3 });
			Impl.Rectangle expected = new Impl.Rectangle()
			{
				X = 1,
				Y = 2,
				Height = -2,
				Width = 3
			};
			//act
			Impl.Rectangle rectangle = Service.FindRectangle(list);
			//assert
			Assert.IsNotNull(rectangle);
			Assert.AreEqual(expected.X, rectangle.X);
			Assert.AreEqual(expected.Y, rectangle.Y);
			Assert.AreEqual(expected.Width, rectangle.Width);
			Assert.AreEqual(expected.Height, rectangle.Height);
		}
	}
}