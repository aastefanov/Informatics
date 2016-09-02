using System;
using System.Linq;

class RhombusOfStars
{
    public static void Main ( string[] args )
    {
        int n = int.Parse ( Console.ReadLine () );

        for ( int i = 1; i <= n; i++ )
        {
            Console.WriteLine (new String(' ', n-i) + string.Concat(Enumerable.Repeat("* ", i)));
        }

        for ( int i = n - 1; i >= 0; i-- )
        {
            Console.WriteLine (new String(' ', n-i) + string.Concat(Enumerable.Repeat("* ", i)));
        }
    }
}
