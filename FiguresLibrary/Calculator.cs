using FiguresLibrary.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLibrary
{
	public static class Calculator
	{
		public static double Calculate(IFigure figure)
		{
			return figure.Area();
		}

		public static bool RectangleTriagle(Triangle triangle)
		{
			return triangle.Rectangular();
		}
	}
}
