using System;
using System.Collections.Generic;
using System.Linq;

namespace Rectangle.Impl
{
	public static class Service
	{
		/// <summary>
		/// See TODO.txt file for task details.
		/// Do not change contracts: input and output arguments, method name and access modifiers
		/// </summary>
		/// <param name="points"></param>
		/// <returns></returns>
		public static Rectangle FindRectangle(List<Point> points)
		{
			Rectangle rect = null;
			if (points.Count < 2 || points == null || points.Distinct().Count() != points.Count()) 
			{
				throw new ArgumentException("Given points are invalid");
			}
			//geting maximum and minimum coordinates points
			int minY = points.Select(x => x.Y).Min();
			int maxY = points.Select(x => x.Y).Max();
			int minX = points.Select(x => x.X).Min();
			int maxX = points.Select(x => x.X).Max();
			//only one point whene x equals maxX
			if (points.Where(x => x.X == maxX).Count() == 1)
				rect = new Rectangle()
				{
					X = maxX - 1,
					Y = minY,
					Height = maxY - minY + 1,
					Width = minX - maxX
				};
			//only one point whene x equals minX
			else if (points.Where(x => x.X == minX).Count() == 1)
				rect = new Rectangle()
				{
					X = minX + 1,
					Y = minY,
					Height = maxY - minY + 1,
					Width = maxX - minX
				};
			//only one point whene y equals minY
			else if (points.Where(x => x.Y == minY).Count() == 1)
				rect = new Rectangle()
				{
					X = minX,
					Y = minY + 1,
					Height = maxY - minY,
					Width = maxX - minX + 1
				};
			//only one point whene Y equals maxY
			else if (points.Where(x => x.Y == maxY).Count() == 1)
				rect = new Rectangle()
				{
					X = minX,
					Y = maxY - 1,
					Height = minY - maxY,
					Width = maxX - minX + 1
				};
			else
				throw new ArgumentException("Given points are invalid");

			return rect;
		}
	}
}
