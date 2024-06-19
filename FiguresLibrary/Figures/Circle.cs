using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLibrary.Figures
{
	public class Circle : IFigure
	{
		private double radius;

		public double Radius
		{
			get => radius; set
			{
				if (value < 0)
					radius = 0.1;
				else
					radius = value;
			}
		}

		public double Area()
		{
			return Math.Round(Math.PI * Math.Pow(Radius, 2),2);
		}
	}
}
