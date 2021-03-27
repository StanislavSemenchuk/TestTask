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
        public void ValidResultWithOneMinY()
        {
            //Arrange
            var points = TestData.rightPoints[0];
            var expected = TestData.rightExpected[0];
            //Act
            Impl.Rectangle rectangle = Service.FindRectangle(points);
            //Assert
            Assert.IsNotNull(rectangle);
            Assert.AreEqual(expected.X, rectangle.X);
            Assert.AreEqual(expected.Y, rectangle.Y);
            Assert.AreEqual(expected.Width, rectangle.Width);
            Assert.AreEqual(expected.Height, rectangle.Height);
        }
    }
}