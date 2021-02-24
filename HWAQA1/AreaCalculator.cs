using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWAQA1
{
	public class AreaCalculator
	{
		public static void CircleArea()
		{
			Helper helper = new Helper();
			Console.WriteLine("Enter circle radius and press enter:");
			var radius = helper.GetValueFromConsole();

			Circle circle = new Circle(radius);
			Console.WriteLine("Circle area: " + Math.Round(circle.GetArea(), 2));
			Console.WriteLine("Press any key...");
			Console.ReadKey();
		}

		public static void SquareArea()
		{
			Helper helper = new Helper();
			Console.WriteLine("Enter rectangle side and press enter:");
			var squareSide = helper.GetValueFromConsole();

			Square square = new Square(squareSide);
			Console.WriteLine("Rectangle area: " + Math.Round(square.GetArea(), 2));
			Console.WriteLine("Press any key...");
			Console.ReadKey();
		}
	}
}
