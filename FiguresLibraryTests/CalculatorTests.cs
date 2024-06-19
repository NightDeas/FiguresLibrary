using Microsoft.VisualStudio.TestTools.UnitTesting;
using FiguresLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using FiguresLibrary.Figures;

namespace FiguresLibrary.Tests
{
	[TestClass()]
	public class CalculatorTests
	{
		[TestMethod()]
		[DataRow(3, 28.27)]
		[DataRow(4, 50.27)]
		public void CalculateAreaCircle(double radius, double expectedResult)
		{
			Circle figure = new()
			{
				Radius = radius
			};


			Assert.AreEqual(expectedResult, figure.Area());
		}


		[TestMethod()]
		[DataRow(1, 1, 1, 0.43)]
		public void CalculateAreaSquare(double sideFromHeight, double side1, double side2, double expectedResult)
		{
			Triangle figure = new()
			{
				Side1 = side1,
				Side2 = side2,
				SideFromHeight = sideFromHeight,
			};


			Assert.AreEqual(expectedResult, figure.Area());
		}
	}
}