using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLibrary.Figures
{
	public class Triangle : IFigure
	{
		private double sideFromHeight;
		private double side1;
		private double side2;

		
		public double SideFromHeight
		{
			get => sideFromHeight;
			set
			{
				if (value > 0)
					sideFromHeight = value;
				else
					sideFromHeight = 0.1;
			}
		}
		public double Side1
		{
			get => side1;
			set
			{
				if (value > 0)
					side1 = value;
				else
					side1 = 0.1;
			}
		}
		public double Side2
		{
			get => side2; set
			{
				if (value > 0)
					side2 = value;
				else
					side2 = 0.1;
			}
		}
		public double Area()
		{
			double p = (SideFromHeight + Side1 + Side2) / 2;

			//S = √(р (р — а)(р — b)(p — c)),
			double S = Math.Sqrt(p*(p - Side1) * (p - Side2) * (p - SideFromHeight));
			return Math.Round(S, 2);

		}

		public bool Rectangular()
		{
			return Math.Pow(Side1, 2) + Math.Pow(Side2, 2) == Math.Pow(SideFromHeight, 2);
		}
	}
}
