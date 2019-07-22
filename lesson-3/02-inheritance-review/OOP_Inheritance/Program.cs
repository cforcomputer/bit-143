using System;
using System.Collections.Generic;
using System.Text;

namespace OOPBasics
{
	class Program
	{
		static void Main(string[] args)
		{
			Rectangle r1 = new Rectangle(10, 20);

			Console.WriteLine("Height is: {0} Area is: {1}", r1.getHeight(),
				r1.calculateArea());

			Rectangle3D r3d_1 = new Rectangle3D(10, 20, 20);

			Console.WriteLine("Height is: {0} Area is: {1} Vol is: {2}", 
				r3d_1.getHeight(),
				r3d_1.calculateArea(), 
				r3d_1.calculateVolume());

		}
	}

	class Rectangle
	{
		private double width;
		private double height;

		public Rectangle(double w, double h)
		{
			width = w;
			setHeight(h);
		}

		public double calculateArea()
		{
			return width * height;
		}

		public double getHeight()
		{
			return height;
		}

		public void setHeight(double h)
		{
			if (h >= 0)
				height = h;
			else
				height = 0;
		}
	}

	class Rectangle3D : Rectangle
	{
		private double depth;

		public Rectangle3D(double w, double h, double d)
			: base(w, h)
		{
			setDepth(d);
		}

		public double getDepth()
		{
			return depth;
		}

		public void setDepth(double d)
		{
			if (d >= 0)
				depth = d;
			else
				depth = 0;
		}

		public double calculateVolume()
		{
			return calculateArea() * depth;
		}
	}

}
