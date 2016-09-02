using System;

class NumberInRange1To100
{
    public static void Main(string[] args)
    {
        input:
        int n = int.Parse(Console.ReadLine());

        if (n < 1 || n > 100)
        {
            Console.WriteLine("Invalid Number!");
            goto input;
        }

        Console.WriteLine("The number is: {0}", n);
    }
}
