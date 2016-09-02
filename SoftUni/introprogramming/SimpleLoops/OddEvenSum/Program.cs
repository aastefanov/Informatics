using System;
using System.Collections.Generic;

namespace OddEvenSum
{
    class MainClass
    {
        public static void Main ( string[] args )
        {
            int n = int.Parse ( Console.ReadLine () );

            Dictionary <int,int> sums = new Dictionary<int, int> ();

            sums.Add ( 0, 0 );
            sums.Add ( 1, 0 );

            for ( int i = 0; i < n; i++ )
            {
                int currentNumber = int.Parse ( Console.ReadLine () );

                sums [ i % 2 ] += currentNumber;
            }

            if ( sums [ 0 ] == sums [ 1 ] )
            {
                Console.WriteLine ( "Yes" );
                Console.WriteLine ( "Sum = {0}", sums [ 0 ] );
            }
            else
            {
                Console.WriteLine ( "No" );
                Console.WriteLine ( "Diff = {0}", Math.Abs ( sums [ 0 ] - sums [ 1 ] ) );
            }
        }
    }
}
