using System;

class ChristmasTree
{
    public static void Main ( string[] args )
    {
        int n = int.Parse ( Console.ReadLine () );

        for ( int i = 0; i <= n; i++ )
        {
            Console.WriteLine ( 
                new String ( ' ', n - i ) + new String ( '*', i ) +
                " | " +
                new String ( '*', i ) + new String ( ' ', n - i ) );
        }
    }
}
