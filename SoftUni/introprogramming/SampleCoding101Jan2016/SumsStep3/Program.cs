using System;
using System.Collections.Generic;

namespace SumsStep3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> scoresList = new List<int> { 0, 0, 0 };

            for (int i = 0; i < n; i++)
            {
                scoresList[i % 3] += int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"sum1 = {scoresList[0]}");
            Console.WriteLine($"sum2 = {scoresList[1]}");
            Console.WriteLine($"sum3 = {scoresList[2]}");

        }
    }
}
