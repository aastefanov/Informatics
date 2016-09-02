using System;

class StupidPasswordGenerator
{
    public static void Main ( string[] args )
    {
        int maxNumber = int.Parse ( Console.ReadLine () );
        int maxLetterAsInt = int.Parse ( Console.ReadLine () );

        maxLetterAsInt += 96;

        char maxLetter = ( char ) maxLetterAsInt;

        for ( int i = 1; i <= maxNumber; i++ )
        {
            for ( int j = 1; j <= maxNumber; j++ )
            {
                for ( char k = 'a'; k <= maxLetter; k++ )
                {
                    for ( char l = 'a'; l <= maxLetter; l++ )
                    {
                        for ( int m = 1; m <= maxNumber; m++ )
                        {
                            if ( m <= i || m <= j )
                            {
                                m = Math.Max ( i, j );
                            }
                            else
                            {
                                Console.Write ( "{0}{1}{2}{3}{4} ", i, j, k, l, m );
                            }
                        }
                    }
                }
            }
        }

        Console.WriteLine ();
    }
}