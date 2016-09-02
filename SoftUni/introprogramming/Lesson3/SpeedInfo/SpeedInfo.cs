using System;

class SpeedInfo
{
    public static void Main ( string[] args )
    {
        double speed = double.Parse ( Console.ReadLine () );

        if ( speed <= 10d )
        {
            Console.WriteLine ( "Slow" );
        }
        else if ( speed <= 50d )
        {
            Console.WriteLine ( "Average" );
        }
        else if ( speed <= 150d )
        {
            Console.WriteLine ( "Fast" );
        }
        else if ( speed <= 1000 )
        {
            Console.WriteLine ( "Ultra fast" );
        }
        else
        {
            Console.WriteLine ( "Extremely fast" );
        }
    }
}
