﻿using System;


class TriangleArea
{
	public static void Main ( string[] args )
	{
		double a = double.Parse (Console.ReadLine ());
		double h = double.Parse (Console.ReadLine ());
		double area = a * h / 2;
		Console.WriteLine (Math.Round (area, 2));
	}
}

