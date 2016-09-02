using System;

class NumberPyramid
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int currNum = 1;
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                if (currNum > n) return;
                Console.Write(currNum + " ");
                currNum++;
            }
            Console.WriteLine();
        }
    }
}
