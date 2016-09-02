using System;
using System.Collections.Generic;

class VowelsSum
{
    public static void Main ( string[] args )
    {
        string word = Console.ReadLine ();
        int score = 0;

        Dictionary <char,int> scores = new Dictionary<char, int> ();

        scores.Add ( 'a', 1 );
        scores.Add ( 'e', 2 );
        scores.Add ( 'i', 3 );
        scores.Add ( 'o', 4 );
        scores.Add ( 'u', 5 );


        foreach ( char letter in word )
        {
            if ( scores.ContainsKey ( letter ) )
            {
                score += scores [ letter ];
            }
        }

        Console.WriteLine ( score );
    }
}