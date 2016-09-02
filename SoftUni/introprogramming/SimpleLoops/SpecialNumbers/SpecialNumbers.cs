using System;
using System.Collections.Generic;

class SpecialNumbers
{
    public static void Main ( string[] args )
    {
        int n = int.Parse ( Console.ReadLine () );

        List <int> digits = new List<int> ();

        for ( int i = 1; i <= 9; i++ )
        {
            if ( n % i == 0 )
            {
                digits.Add ( i );
            }
        }

        foreach ( int i in digits )
        {
            foreach ( int j in digits )
            {

                foreach ( int k in digits )
                {

                    foreach ( int l in digits )
                    {
                        Console.Write ("{0}{1}{2}{3} ", i, j, k, l  );
                    }
                }
            }       
        }
    }
}
