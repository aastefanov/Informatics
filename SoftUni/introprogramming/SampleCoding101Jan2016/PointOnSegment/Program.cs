using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOnSegment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int point = int.Parse(Console.ReadLine());

            if (first > second)
            {
                int tmp = first;
                first = second;
                second = tmp;
            }

            Console.WriteLine(point >= first && point <= second ? "in" : "out");

            int diffToFirst = Math.Abs(point - first);
            int diffToSecond = Math.Abs(point - second);

            Console.WriteLine(diffToFirst < diffToSecond ? diffToFirst : diffToSecond);
        }
    }
}
