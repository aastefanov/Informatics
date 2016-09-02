using System;

namespace DateAfter5Days
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());

            DateTime time = new DateTime(year: 2001, month: month, day: day);

            time = time.AddDays(5);

            Console.WriteLine(time.ToString("d.MM"));
        }
    }
}
