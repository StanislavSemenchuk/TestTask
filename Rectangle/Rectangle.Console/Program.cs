using System.Collections.Generic;
using Rectangle.Impl;

namespace Rectangle.Console
{
    class Program
	{
		/// <summary>
		/// Use this method for local debugging only. The implementation should remain in Rectangle.Impl project.
		/// See TODO.txt file for task details.
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			var rectangle = Service.FindRectangle(new List<Point>
			{
				new Point() { X = 1, Y = 3 },
				new Point() { X = 1, Y = 2 },
				new Point() { X = 3, Y = 1 },
				new Point() { X = 3, Y = 3 }
			});
			System.Console.ReadKey();
		}
	}
}
