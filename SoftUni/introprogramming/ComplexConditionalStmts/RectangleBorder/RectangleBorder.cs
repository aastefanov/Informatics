using System;

class RectangleBorder
{
    public static void Main ( string[] args )
    {
        //Input
        double rectangleLeftX = double.Parse ( Console.ReadLine () );
        double rectangleBottomY = double.Parse ( Console.ReadLine () );
        double rectangleRightX = double.Parse ( Console.ReadLine () );
        double rectangleTopY = double.Parse ( Console.ReadLine () );
        double pointX = double.Parse ( Console.ReadLine () );
        double pointY = double.Parse ( Console.ReadLine () );

        bool isOnTop = ( ( rectangleTopY == pointY ) &&
                       ( pointX >= rectangleLeftX && pointX <= rectangleRightX ) );

        bool isOnBottom = ( ( rectangleBottomY == pointY ) &&
                          ( pointX >= rectangleLeftX && pointX <= rectangleRightX ) );

        bool isOnLeft = ( ( rectangleLeftX == pointX ) &&
                        ( pointY >= rectangleBottomY && pointY <= rectangleTopY ) );
        
        bool isOnRight = ( ( rectangleRightX == pointX ) &&
                         ( pointY >= rectangleBottomY && pointY <= rectangleTopY ) );

        bool isOnRectangle = ( isOnTop || isOnRight || isOnLeft || isOnBottom );
        Console.WriteLine ( isOnRectangle ? "Border" : "Inside / Outside" );
    }
}
