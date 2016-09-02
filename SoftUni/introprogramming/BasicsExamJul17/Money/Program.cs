using System;

class Money
{
    public static void Main(string[] args)
    {
        double bitcoin = double.Parse(Console.ReadLine());
        double yuan = double.Parse(Console.ReadLine());
        double tax = double.Parse(Console.ReadLine());

        double bitcoinAsEUR = bitcoin * 1168 / 1.95;

        double yuanAsEUR = yuan * 0.15 * 1.76 / 1.95;

        double result = (bitcoinAsEUR + yuanAsEUR) * (1 - (tax / 100));

        Console.WriteLine(result);
    }
}