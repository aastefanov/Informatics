using System;

class RectangleOf10X10Stars
{
    public static void Main ( string[] args )
    {

        string stars = new string ( '*', 10 );
        for ( int i = 0; i < 10; i++ )
        {
            Console.WriteLine ( stars );
        }
    }
}