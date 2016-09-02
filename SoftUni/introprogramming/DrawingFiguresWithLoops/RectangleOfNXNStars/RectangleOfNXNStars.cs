using System;

class RectangleOfNXNStars
{
    public static void Main ( string[] args )
    {
        int n = int.Parse ( Console.ReadLine () );
        string stars = new string ( '*', n );
        for ( int i = 0; i < n; i++ )
        {
            Console.WriteLine ( stars );
        }
    }
}