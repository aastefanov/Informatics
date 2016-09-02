using System;

class CheckPrime
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        if (n <= 0 || n==1)
        {
            Console.WriteLine("Not prime");
            return;
        }

        bool prime = true;

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                prime = false;
                break;
            }
        }

        Console.WriteLine(prime ? "Prime" : "Not prime");
    }
}