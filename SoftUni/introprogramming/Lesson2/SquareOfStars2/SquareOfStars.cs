using System;

class SquareOfStars
{
	public static void Main ( string[] args )
	{
		int n = int.Parse (Console.ReadLine ());
		if (n != 1)
		{
			string topbottom = new string ('*', n);
			string spaces = new string (' ', n - 2);
			string row = '*' + spaces + '*';
			Console.WriteLine (topbottom);
			for (int i = 1; i < n - 1; ++i)
			{
				Console.WriteLine (row);
			}
			Console.WriteLine (topbottom);
		} else
		{
			Console.WriteLine ("*");
		}
	}
}
