using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWAQA1
{
	public class Square
	{
		private double _squareArea;
		public double SquareArea
		{
			get { return _squareArea; }
			set
			{
				_squareArea = value;
			}
		}

		public Square(double squareArea)
		{
			SquareArea = squareArea;
		}

		public double GetArea()
		{
			return Math.Pow(SquareArea, 2);
		}
	}
}
