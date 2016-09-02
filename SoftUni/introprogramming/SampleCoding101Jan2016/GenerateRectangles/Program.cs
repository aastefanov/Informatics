using System;

namespace GenerateRectangles
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            bool hasRectangles = false;

            for (int i = -n; i < n; i++)
            {
                for (int j = i + 1; j <= n; j++)
                {
                    for (int k = -n; k < n; k++)
                    {
                        for (int l = k + 1; l <= n; l++)
                        {
                            int sideA = Math.Abs(j - i);
                            int sideB = Math.Abs(k - l);

                            if (sideA * sideB < m) continue;

                            Console.WriteLine($"({i}, {k}) ({j}, {l}) -> {sideA * sideB}");
                            hasRectangles = true;
                        }
                    }
                }
            }

            if (!hasRectangles)
            {
                Console.WriteLine("No");
            }
        }
    }
}
