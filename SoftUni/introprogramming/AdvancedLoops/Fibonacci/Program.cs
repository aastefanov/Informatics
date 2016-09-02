using System;

class Fibonacci
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int first = 1;
        int second = 1;
        for (int i = 0; i < n; i++)
        {
            int next = first + second;
            second = first;
            first = next;
        }

        Console.WriteLine(second);
    }
}
