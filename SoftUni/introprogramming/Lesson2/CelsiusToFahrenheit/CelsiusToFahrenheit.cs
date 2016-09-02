using System;

class CelsiusToFahrenheit
{
	public static void Main ( string[] args )
	{
		double celsius = double.Parse (Console.ReadLine ());
		double fahrenheit = celsius * 1.8 + 32;
		Console.WriteLine (Math.Round (fahrenheit, 2));
	}
}

