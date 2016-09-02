using System;

class CircleAreaPerimeter
{
	public static void Main ( string[] args )
	{
		double radius = double.Parse (Console.ReadLine ());
		double area = Math.PI * Math.Pow (radius, 2.0);
		double perimeter = Math.PI * radius * 2;
		Console.WriteLine ("Area = {0}\nPerimeter = {1}", area, perimeter);
	}
}
