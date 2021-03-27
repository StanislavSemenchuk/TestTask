using System;
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
        [Test]
        public void ValidResultWithOneMaxY()
        {
            //Arrange
            var points = TestData.rightPoints[1];
            var expected = TestData.rightExpected[1];
            //Act
            Impl.Rectangle rectangle = Service.FindRectangle(points);
            //Assert
            Assert.IsNotNull(rectangle);
            Assert.AreEqual(expected.X, rectangle.X);
            Assert.AreEqual(expected.Y, rectangle.Y);
            Assert.AreEqual(expected.Width, rectangle.Width);
            Assert.AreEqual(expected.Height, rectangle.Height);
        }
        [Test]
        public void ValidResultWithOneMinX()
        {
            //Arrange
            var points = TestData.rightPoints[2];
            var expected = TestData.rightExpected[2];
            //Act
            Impl.Rectangle rectangle = Service.FindRectangle(points);
            //Assert
            Assert.IsNotNull(rectangle);
            Assert.AreEqual(expected.X, rectangle.X);
            Assert.AreEqual(expected.Y, rectangle.Y);
            Assert.AreEqual(expected.Width, rectangle.Width);
            Assert.AreEqual(expected.Height, rectangle.Height);
        }
        [Test]
        public void ValidResultWithOneMaxX()
        {
            //Arrange
            var points = TestData.rightPoints[3];
            var expected = TestData.rightExpected[3];
            //Act
            Impl.Rectangle rectangle = Service.FindRectangle(points);
            //Assert
            Assert.IsNotNull(rectangle);
            Assert.AreEqual(expected.X, rectangle.X);
            Assert.AreEqual(expected.Y, rectangle.Y);
            Assert.AreEqual(expected.Width, rectangle.Width);
            Assert.AreEqual(expected.Height, rectangle.Height);
        }

        [Test]
        public void ThrowsArgumentExcetpionWhenPointsisNull()
        {
            //Arrange
            var points = TestData.invalidPoints[0];

            //Assert
            Assert.Throws<ArgumentException>(()=>Service.FindRectangle(points));
        }

        [Test]
        public void ThrowsNullRefExcetpionWhenPointisNull()
        {
            //Arrange
            var points = TestData.invalidPoints[1];

            //Assert
            Assert.Throws<NullReferenceException>(() => Service.FindRectangle(points));
        }

        [Test]
        public void ThrowsArgumentExcetpionWhenPointsAreSame()
        {
            //Arrange
            var points = TestData.invalidPoints[2];

            //Assert
            Assert.Throws<ArgumentException>(() => Service.FindRectangle(points));
        }

        [Test]
        public void ThrowsArgumentExcetpionWhenPointsLessThenTwo()
        {
            //Arrange
            var points = TestData.invalidPoints[0];

            //Assert
            Assert.Throws<ArgumentException>(() => Service.FindRectangle(points));
        }
    }
}