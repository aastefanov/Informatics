using System;

namespace Histogram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] pCount = new int[5];
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int curr = int.Parse(Console.ReadLine());

                if (curr < 200)
                {
                    pCount[0]++;
                }
                else if (curr < 400)
                {
                    pCount[1]++;
                }
                else if (curr < 600)
                {
                    pCount[2]++;
                }
                else if (curr < 800)
                {
                    pCount[3]++;
                }
                else
                {
                    pCount[4]++;
                }

            }

            foreach (int i in pCount)
            {
                //Console.WriteLine(i);
                Console.WriteLine($"{i*1.0/n*100d:00.00}%");
            }
        }
    }
}
