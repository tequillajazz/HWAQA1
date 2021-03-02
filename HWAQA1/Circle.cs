using System;

namespace HWAQA1
{
	public class Circle
	{
		private double _radius;
		public double Radius
		{
			get { return _radius; }
			set
			{
				_radius = value;
			}
		}

		public Circle(double radius)
		{
			Radius = radius;
		}

		public double GetArea()
		{
			return Math.PI * Math.Pow(Radius, 2);
		}
	}
}
