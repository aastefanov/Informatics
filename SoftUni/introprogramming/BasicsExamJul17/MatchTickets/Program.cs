using System;

class MatchTickets
{
    public static void Main(string[] args)
    {
        decimal budget = decimal.Parse(Console.ReadLine());
        string ticketType = Console.ReadLine();
        decimal ticketPrice = ticketType == "VIP" ? 499.99m : 249.99m;
        uint peopleInGroup = uint.Parse(Console.ReadLine());

        #region Transport
        if (peopleInGroup <= 4)
        {
            budget *= 0.25m;
        }
        else if (peopleInGroup <= 9)
        {
            budget *= 0.40m;
        }
        else if (peopleInGroup <= 24)
        {
            budget *= 0.50m;
        }
        else if (peopleInGroup <= 49)
        {
            budget *= 0.6m;
        }
        else
        {
            budget *= 0.75m;
        }
        #endregion

        budget -= peopleInGroup*ticketPrice;
        bool isBudgetEnough = (budget >= 0);
        budget = Math.Abs(budget);

        Console.WriteLine(isBudgetEnough
            ? $"Yes! You have {budget:F2} leva left."
            : $"Not enough money! You need {budget:F2} leva.");
    }
}