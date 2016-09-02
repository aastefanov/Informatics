using System;

namespace Increasing4Numbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (Math.Abs(a - b) < 3)
            {
                Console.WriteLine("no");
                return;
            }

            int i = a,
                j = i + 1,
                k = j + 1,
                l = k + 1;
            for (i = a; i < j; i++)
                for (j = i + 1; j < k; j++)
                    for (k = j + 1; k < l; k++)
                        for (l = k + 1; l <= b; l++)
                            Console.WriteLine($"{i} {j} {k} {l}");
        }
    }
}
