using System;

class PassionDays
{
    public static void Main(string[] args)
    {
        decimal money = decimal.Parse(Console.ReadLine());

        while (Console.ReadLine() != "mall.Enter")
        {
        }

        int i = 0;
        while (true)
        {
            string productAsString = Console.ReadLine();
            if (productAsString == "mall.Exit")
            {
                break;
            }
            foreach (char product in productAsString)
            {

                if (product >= 'A' && product <= 'Z')
                {
                    decimal change = 0.5m * (int)product;
                    if (change > money)
                    {
                        continue;
                    }

                    money -= change;
                    i++;
                    continue;
                }
                if (product >= 'a' && product <= 'z')
                {
                    decimal change = 0.3m * (int)product;
                    if (change > money)
                    {
                        continue;
                    }

                    money -= change;
                    i++;
                    continue;
                }
                if (product == '%')
                {
                    if (money > 0)
                    {
                        money /= 2;
                        i++;
                    }
                    continue;
                }
                if (product == '*')
                {
                    money += 10;
                    continue;
                }

                {
                    decimal change = (int) product;
                    if (change > money)
                    {
                        continue;
                    }
                    money -= change;
                    i++;
                }
            }
        }

        Console.WriteLine($"{(i == 0 ? "No" : i.ToString())} purchases. Money left: {money:F2} lv.");
    }
}
