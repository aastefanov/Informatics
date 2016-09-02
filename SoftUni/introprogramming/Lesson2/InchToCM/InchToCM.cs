using System;

class InchToCM
{
	public static void Main ( string[] args )
	{
		decimal input = decimal.Parse (Console.ReadLine ());
		decimal inch = 2.54m;
		decimal cm = input * inch;
		Console.WriteLine (cm);
	}
}
