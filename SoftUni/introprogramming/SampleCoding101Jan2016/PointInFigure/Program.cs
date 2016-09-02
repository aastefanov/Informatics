using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInFigure
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int pointX = int.Parse(Console.ReadLine());
            int pointY = int.Parse(Console.ReadLine());

            if (pointY > 3 || pointY < -5 || pointX < 2 || pointX > 12)
            {
                Console.WriteLine("out");
                return;
            }

            if (pointY >= -3 && pointY <= 1)
            {
                Console.WriteLine("in");
                return;
            }

            if (pointX >= 4 && pointX <= 10)
            {
                Console.WriteLine("in");
                return;
            }

            Console.WriteLine("out");
        }
    }
}
