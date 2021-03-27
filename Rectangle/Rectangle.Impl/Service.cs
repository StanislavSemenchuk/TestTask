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
			if (points.Count < 2 || points == null || points.Distinct().Count() != points.Count()) 
			{
				throw new ArgumentException("Given points are invalid");
			}

			int minY = points.Select(x => x.Y).Min();
			int maxY = points.Select(x => x.Y).Max();
			int minX = points.Select(x => x.X).Min();
			int maxX = points.Select(x => x.X).Max();

			throw new NotImplementedException();
		}
	}
}
