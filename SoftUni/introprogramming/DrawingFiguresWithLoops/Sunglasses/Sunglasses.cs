using System;

class Sunglasses
{
	public static void Main(string[] args)
	{
		int n = int.Parse(Console.ReadLine());

		string topBottomRow = new string('*', 2 * n) + new string(' ', n) + new string('*', 2 * n);

		string glassPart = "*" + new string('|', 2 * n - 2) + "*";

		string slashes = new string('/', n);
		Console.WriteLine(topBottomRow);


		for (int i = 0; i < n / 2 - 1; i++)
		{
			Console.WriteLine(glassPart + new string(' ', n) + glassPart);
		}

		Console.WriteLine(glassPart + slashes + glassPart);

		for (int i = 0; i < n / 2 - 1; i++)
		{
			Console.WriteLine(glassPart + new string(' ', n) + glassPart);
		}

		Console.WriteLine(topBottomRow);
	}
}