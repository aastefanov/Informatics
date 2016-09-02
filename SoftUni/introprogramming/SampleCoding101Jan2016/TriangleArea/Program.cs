using System;

namespace TriangleArea
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region Input
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int x3 = int.Parse(Console.ReadLine());
            int y3 = int.Parse(Console.ReadLine());
            #endregion

            int height = Math.Abs(y1 - y2);

            int length = Math.Abs(x3 - x2);

            double area = height * length / 2.0;

            Console.WriteLine(area);
        }
    }
}
