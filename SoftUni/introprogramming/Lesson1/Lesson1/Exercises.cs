using System;

namespace Lesson1
{
	class SquareOfStars
	{
		static void Main ( string[] args )
		{
			var n = int.Parse (Console.ReadLine ());
			for (int i = 0; i < n; ++i)
			{
				Console.Write ("*");
			}
			Console.WriteLine ();
			for (int i = 0; i < n - 2; ++i)
			{
				Console.Write ("*");
				for (int j = 1; j < n - 1; ++j)
				{
					Console.Write (" ");
				}
				Console.WriteLine ("*");
			}
			for (int i = 0; i < n; ++i)
			{
				Console.Write ("*");
			}
			Console.WriteLine ();
		}
	}
}
