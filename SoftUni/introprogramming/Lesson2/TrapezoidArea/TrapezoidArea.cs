using System;

class TrapezoidArea
{
	public static void Main ( string[] args )
	{
		decimal a = decimal.Parse (Console.ReadLine ());
		decimal b = decimal.Parse (Console.ReadLine ());
		decimal h = decimal.Parse (Console.ReadLine ());
		decimal area = ((a + b) / 2) * h;
		Console.WriteLine (area);
	}
}
