using System;

class GreatestCommonDivisor
{
    public static void Main(string[] args)
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());

        while (num2 != 0)
        {
            int old2 = num2;
            num2 = num1 % num2;
            num1 = old2;
        }

        Console.WriteLine(num1);
    }
}