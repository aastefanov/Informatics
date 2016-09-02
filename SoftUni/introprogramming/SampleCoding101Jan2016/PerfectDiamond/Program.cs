using System;

namespace PerfectDiamond
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int maxStars = int.Parse(Console.ReadLine());

            #region Top
            for (int currentStars = 1; currentStars <= maxStars; currentStars++)
            {
                Console.Write(new string(' ', maxStars - currentStars));
                for (int j = 1; j < currentStars; j++)
                {
                    Console.Write("*-");
                }
                Console.WriteLine("*");
            }
            #endregion

            #region Bottom
            for (int currentStars = maxStars - 1; currentStars >= 1; currentStars--)
            {
                Console.Write(new string(' ', maxStars - currentStars));
                for (int j = 1; j < currentStars; j++)
                {
                    Console.Write("*-");
                }
                Console.WriteLine("*");
            }
            #endregion
        }
    }
}
