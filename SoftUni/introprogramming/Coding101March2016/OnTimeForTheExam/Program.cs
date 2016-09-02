using System;

namespace OnTimeForTheExam
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMin = int.Parse(Console.ReadLine());
            int studentHour = int.Parse(Console.ReadLine());
            int studentMin = int.Parse(Console.ReadLine());

            TimeSpan diffSpan = new TimeSpan(studentHour, studentMin, 0) - new TimeSpan(examHour, examMin, 0);
            bool isLate = !(diffSpan.TotalMinutes <= 0);

            int diffHours = Math.Abs(diffSpan.Hours);
            int diffMin = Math.Abs(diffSpan.Minutes);

            //Console.WriteLine($"{diffSpan.Hours}:{diffSpan.Minutes}");

            if (isLate)
            {
                Console.WriteLine("Late");
                Console.WriteLine(diffHours > 0
                    ? $"{diffHours}:{diffMin:00} hours after the start"
                    : $"{diffMin} minutes after the start");
            }
            else
            {
                if (diffMin <= 30 && diffHours == 0)
                {
                    Console.WriteLine("On time");
                    if (diffMin != 0)
                    {
                        Console.WriteLine($"{diffMin} minutes before the start");
                    }
                }
                else
                {
                    Console.WriteLine("Early");
                    Console.WriteLine(diffHours > 0
                        ? $"{diffHours}:{diffMin:00} hours before the start"
                        : $"{diffMin} minutes before the start");
                }
            }
        }
    }
}