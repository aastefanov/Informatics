using System;

class PointInRectangle
{
    public static void Main ( string[] args )
    {
        //Input
        double rectangleLeftX = double.Parse ( Console.ReadLine () );
        double rectangleTopY = double.Parse ( Console.ReadLine () );
        double rectangleRightX = double.Parse ( Console.ReadLine () );
        double rectangleBottomY = double.Parse ( Console.ReadLine () );
        double pointX = double.Parse ( Console.ReadLine () );
        double pointY = double.Parse ( Console.ReadLine () );

        bool isXValid = ( ( pointX >= rectangleLeftX ) && ( pointX <= rectangleRightX ) );
        if ( !isXValid )
        {
            Console.WriteLine ( "Outside" );
            return;
        }
        bool isYValid = ( ( pointY >= rectangleTopY ) && ( pointY <= rectangleBottomY ) );
        if ( !isYValid )
        {
            Console.WriteLine ( "Outside" );
            return;
        }

        Console.WriteLine ( "Inside" );
    }
}
