using System;

class UsdToBgn
{
	public static void Main ( string[] args )
	{
		decimal usd = decimal.Parse (Console.ReadLine ());
		decimal course = 1.79549m;
		decimal bgn = course * usd;
		Console.WriteLine (Math.Round (bgn, 2));
	}
}

