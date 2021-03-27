using System;
using System.Collections.Generic;
using System.Text;

namespace Rectangle.Impl
{
	public sealed class Point : IEquatable<Point>
	{
		public int X { get; set; }
		public int Y { get; set; }

        public bool Equals(Point other)
        {
            //Check whether the compared object is null.
            if (Object.ReferenceEquals(other, null)) return false;

            //Check whether the compared object references the same data.
            if (Object.ReferenceEquals(this, other)) return true;

            //Check whether the points' properties are equal.
            return Y.Equals(other.Y) && X.Equals(other.X);
        }

        public override int GetHashCode()
        {
            //Get hash code for the X field.
            int hashPointX = X.GetHashCode();

            //Get hash code for the Y field.
            int hashPointY = Y.GetHashCode();

            //Calculate the hash code for the product.
            return hashPointX ^ hashPointY;
        }
    }
}
