using System;
using System.Collections.Generic;

namespace Sums3Numbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int value1 = int.Parse(Console.ReadLine());
            int value2 = int.Parse(Console.ReadLine());
            int value3 = int.Parse(Console.ReadLine());

            List<int> values = new List<int> { value1, value2, value3 };

            values.Sort();

            value1 = values[0];
            value2 = values[1];
            value3 = values[2];

            if (values.Contains(value1 + value2))
            {
                Console.WriteLine($"{value1} + {value2} = {value3}");
            }
            else if (values.Contains(value1 + value3))
            {
                Console.WriteLine($"{value1} + {value3} = {value2}");
            }
            else if (values.Contains(value2 + value3))
            {
                Console.WriteLine($"{value2} + {value3} = {value1}");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}