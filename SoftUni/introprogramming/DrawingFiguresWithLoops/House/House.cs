using System;

class House
{
	public static void Main(string[] args)
	{
		int n = int.Parse(Console.ReadLine());

		#region Stars

		int stars = (n % 2 == 0) ? 2 : 1;

		for (int i = 0; i <= (n - 1) / 2; i++)
		{
			Console.WriteLine(
				new string('-', (n - stars) / 2) +
				new string('*', stars) +
				new string('-', (n - stars) / 2)
			);

			stars += 2;
		}

		#endregion

		#region Walls

		string wall = "|" + new string('*', n - 2) + "|";

		for (int i = 0; i < n / 2; i++)
		{
			Console.WriteLine(wall);
		}

		#endregion
	}
}