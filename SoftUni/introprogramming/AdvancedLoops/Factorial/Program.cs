using System;
using System.Numerics;

class Factorial
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger num = new BigInteger(1);

        for (int i = 2; i <= n; i++)
        {
            num *= i;
        }

        Console.WriteLine(num);
    }
}