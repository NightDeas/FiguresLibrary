using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLibrary.Figures
{
	public class Square : IFigure
	{
		private double sideLenght;

		public double SideLenght
		{
			get => sideLenght; 
			set
			{
				if (value  < 0)
					sideLenght = 0.1;
				else
					sideLenght = value;
			}
		}
		public double Area()
		{
			return Math.Round(Math.Pow(SideLenght, 2),2);
		}
	}
}
