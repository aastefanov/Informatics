using System;

class EvenPowersOfTwo
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int num = 1;
        for (int i = 0; i <= n/2; i++)
        {
            Console.WriteLine(num);
            num *= 4;
        }
    }
}