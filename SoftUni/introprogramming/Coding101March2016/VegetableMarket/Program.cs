using System;

namespace VegetableMarket
{
	public class Program
	{
		public static void Main(string[] args)
		{
			decimal fruitKilo = decimal.Parse(Console.ReadLine());
			decimal vegetableKilo = decimal.Parse(Console.ReadLine());

			int fruitQuantity = int.Parse(Console.ReadLine());
			int vegetableQuantity = int.Parse(Console.ReadLine());

			decimal fruitIncome = fruitKilo * fruitQuantity;
			decimal vegetableIncome = vegetableKilo * vegetableQuantity;

			decimal incomeBgn = fruitIncome + vegetableIncome;

			decimal incomeEur = incomeBgn / 1.94m;

			Console.WriteLine($"{incomeEur}");
		}
	}
}