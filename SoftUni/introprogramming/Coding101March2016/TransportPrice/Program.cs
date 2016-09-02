using System;

namespace TransportPrice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isDay = (Console.ReadLine() == "day") ? true : false;

            decimal moneyToPay = 0m;

            if (n < 20)
            {
                moneyToPay = 0.70m + (isDay ? 0.79m : 0.90m) * n;
            }
            else if (n < 100)
            {
                moneyToPay = 0.09m * n;
            }
            else
            {
                moneyToPay = 0.06m * n;
            }

            Console.WriteLine($"{moneyToPay:0.##}");
        }
    }
}
