using System;

class EqualWords
{
    public static void Main ( string[] args )
    {
        string firstWord = Console.ReadLine ().ToLower ();
        string secondWord = Console.ReadLine ().ToLower ();

        if ( firstWord == secondWord )
        {
            Console.WriteLine ( "Yes" );
        }
        else
        {
            Console.WriteLine ( "No" );
        }
    }
}

