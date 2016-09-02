using System;

namespace Bricks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int bricks = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int cartSize = int.Parse(Console.ReadLine());

            double minCoursesDouble = ((double)bricks/cartSize)/workers;

            int minCourses = (int) Math.Ceiling(minCoursesDouble);
            Console.WriteLine(minCourses);
        }
    }
}
