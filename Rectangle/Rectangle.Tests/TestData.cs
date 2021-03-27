using Rectangle.Impl;
using System.Collections.Generic;

namespace Rectangle.Tests
{
    class TestData
    {
        public static List<List<Point>> rightPoints = new List<List<Point>>
        {
            new List<Point>
            {
                new Point() { X = 1, Y = 3 },
                new Point() { X = 1, Y = 2 },
                new Point() { X = 3, Y = 1 },
                new Point() { X = 3, Y = 3 }
            },
            new List<Point>
            {
                new Point() { X = 1, Y = 1 },
                new Point() { X = 1, Y = 2 },
                new Point() { X = 3, Y = 1 },
                new Point() { X = 3, Y = 3 }
            },
            new List<Point>
            {
                new Point() { X = 1, Y = 1 },
                new Point() { X = 2, Y = 2 },
                new Point() { X = 3, Y = 1 },
                new Point() { X = 3, Y = 3 }
            },
            new List<Point>
            {
                new Point() { X = 5, Y = 1 },
                new Point() { X = 1, Y = 2 },
                new Point() { X = 3, Y = -1 },
                new Point() { X = 3, Y = 3 }
            }
        };

        public static List<Impl.Rectangle> rightExpected = new List<Impl.Rectangle>
        {
            new Impl.Rectangle
            {
                X = 1,
                Y = 2,
                Height = 2,
                Width = 3
            },
            new Impl.Rectangle
            {
                X = 1,
                Y = 2,
                Height = -2,
                Width = 3
            },
            new Impl.Rectangle
            {
                X = 2,
                Y = 1,
                Height = 3,
                Width = 2
            },
            new Impl.Rectangle
            {
                X = 4,
                Y = -1,
                Height = 5,
                Width = -4
            }
        };
    }
}
