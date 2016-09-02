using System;

class RadiansToDegrees
{
	public static void Main ( string[] args )
	{
		double rad = double.Parse (Console.ReadLine ());
		double deg = rad * 180d / Math.PI;
		Console.WriteLine (Math.Round (deg, 0));
	}
}

