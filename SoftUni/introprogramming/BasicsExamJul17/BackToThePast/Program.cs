using System;

class BackToThePast
{
    public static void Main(string[] args)
    {
        decimal initialMoney = decimal.Parse(Console.ReadLine());

        int finalYear = int.Parse(Console.ReadLine());

        int yearspan = finalYear - 1800;

        int initialAge = 18;

        decimal moneyNeeded = 0m;
        for (int i = 0; i <= yearspan; i++)
        {
            if (i % 2 == 0)
            {
                moneyNeeded += 12000;
            }
            else
            {
                moneyNeeded += 12000 + 50 * (initialAge + i);
            }
        }

        decimal difference = initialMoney - moneyNeeded;

        Console.WriteLine(difference >= 0
            ? $"Yes! He will live a carefree life and will have {Math.Abs(difference):F2} dollars left."
            : $"He will need {Math.Abs(difference):F2} dollars to survive.");
    }
}