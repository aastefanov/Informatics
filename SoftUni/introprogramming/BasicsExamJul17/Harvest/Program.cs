using System;

class Harvest
{
    public static void Main(string[] args)
    {
        int areaSqM = int.Parse(Console.ReadLine());
        double grapesPerSqM = double.Parse(Console.ReadLine());
        int wineNeeded = int.Parse(Console.ReadLine());
        int workers = int.Parse(Console.ReadLine());

        double resultWine = 0.4 * (areaSqM * grapesPerSqM) / 2.5;

        if (wineNeeded <= resultWine)
        {
            Console.WriteLine(
                "Good harvest this year! " +
                $"Total wine: {Math.Floor(resultWine)} liters."
                );

            Console.WriteLine(
                $"{Math.Ceiling(resultWine - wineNeeded)} liters left -> " +
                $"{Math.Ceiling((resultWine - wineNeeded) / workers)} liters per person."
                );
        }
        else
        {
            Console.WriteLine(
                "It will be a tough winter! " +
                $"More {Math.Floor(wineNeeded - resultWine)} liters wine needed."
                );
        }
    }
}