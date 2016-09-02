using System;

class Diamond
{
	public static void Main(string[] args)
	{
		int n = int.Parse(Console.ReadLine());

		#region Ugly Fixes

		if (n == 1)
		{
			Console.WriteLine("*");

			return;
		}

		if (n == 2)
		{
			Console.WriteLine("**");

			return;
		}

		#endregion

		int stars = (n % 2 == 0) ? 2 : 1;
		int outerDashes = (n - stars) / 2;
		int innerDashes = stars;


		string topBottomLine =
			new string('-', outerDashes) +
			new string('*', stars) +
			new string('-', outerDashes);

		Console.WriteLine(topBottomLine);
		outerDashes -= 1;

		for (int i = 0; i < ((n - 1) / 2) - 1; i++)
		{
			Console.WriteLine(
				new string('-', outerDashes) +
				"*" +
				new string('-', innerDashes) +
				"*" +
				new string('-', outerDashes));

			outerDashes -= 1;
			innerDashes += 2;
		}

		for (int i = 0; i < ((n - 1) / 2); i++)
		{
			Console.WriteLine(
				new string('-', outerDashes) +
				"*" +
				new string('-', innerDashes) +
				"*" +
				new string('-', outerDashes));

			outerDashes += 1;
			innerDashes -= 2;
		}

		Console.WriteLine(topBottomLine);
	}
}