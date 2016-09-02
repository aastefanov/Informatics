using System;

namespace TrainingLab
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double hallWidth = double.Parse(Console.ReadLine());
            double hallHeight = double.Parse(Console.ReadLine());

            //To centimeters
            hallWidth *= 100;
            hallHeight *= 100;

            int rows = (int)(hallHeight - 100) / 70;

            int cols = (int)hallWidth / 120;

            int places = rows * cols - 3;

            Console.WriteLine(places);
        }
    }
}
