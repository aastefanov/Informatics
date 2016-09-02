using System;
using System.Linq;

class SquareFrame
{
    public static void Main ( string[] args )
    {
        int n = int.Parse ( Console.ReadLine () );

        string topBottom = "+" + string.Concat ( Enumerable.Repeat ( " -", n - 2 ) ) + " +";

        string middleRow = "|" + string.Concat ( Enumerable.Repeat ( " -", n - 2 ) ) + " |";

        Console.WriteLine ( topBottom );

        for ( int i = 0; i < n - 2; i++ )
        {
            Console.WriteLine ( middleRow );
        }

        Console.WriteLine ( topBottom );
    }
}
