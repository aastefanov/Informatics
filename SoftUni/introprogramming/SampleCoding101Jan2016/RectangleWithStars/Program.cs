using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleWithStars
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string topBottomRow = new string('%', 2 * n);
            string normalRow = "%" + new string(' ', 2 * n - 2) + "%";

            string middleRow = "%" + new string(' ', n - 2) + "**" + new string(' ', n - 2) + "%";
            Console.WriteLine(topBottomRow);

            for (int i = 0; i < (n - 1) / 2; i++)
            {
                Console.WriteLine(normalRow);
            }

            Console.WriteLine(middleRow);

            for (int i = 0; i < (n - 1) / 2; i++)
            {
                Console.WriteLine(normalRow);
            }

            Console.WriteLine(topBottomRow);

        }
    }
}
