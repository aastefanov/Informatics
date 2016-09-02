using System;

class PointInTheFigure
{
    public static void Main ( string[] args )
    {
        #region Input

        int measureSize = int.Parse ( Console.ReadLine () );
        int pointX = int.Parse ( Console.ReadLine () );
        int pointY = int.Parse ( Console.ReadLine () );

        #endregion

        #region Check Rectangles

        // Rectangle 1 (rect1) - [ (h, 4h), (2h, h)]

        bool isInRectangle1 = ( ( pointX > measureSize && pointX < 2 * measureSize ) &&
                              ( pointY > measureSize && pointY < 4 * measureSize ) );
        if ( isInRectangle1 )
        {
            Console.WriteLine ( "inside" );
            return;
        }

        bool isOutOfRectangle1 = ( ( pointX < measureSize || pointX > 2 * measureSize ) ||
                                 ( pointY < measureSize || pointY > 4 * measureSize ) );

        bool isOnRectangle1 = !isOutOfRectangle1;
            
        // Rectangle 2 (rect2) - [ (0, h), (3h, 0)]

        bool isInRectangle2 = ( ( pointX > 0 && pointX < 3 * measureSize ) &&
                              ( pointY > 0 && pointY < measureSize ) );
        if ( isInRectangle2 )
        {
            Console.WriteLine ( "inside" );
            return;
        }

        bool isOutOfRectangle2 = ( ( pointX < 0 || pointX > 3 * measureSize ) ||
                                 ( pointY < 0 || pointY > measureSize ) );

        bool isOnRectangle2 = !isOutOfRectangle2;

        #endregion

        #region Checks - is in figure, closes Method from conditions

        // On angles
        if ( ( pointX == measureSize && pointY == measureSize ) ||
             ( pointX == 2 * measureSize && pointY == measureSize ) )
        {
            Console.WriteLine ( "border" );
            return;
        }

        if ( isOnRectangle1 && isOnRectangle2 )
        {
            Console.WriteLine ( "inside" );
            return;
        }

        if ( isOnRectangle1 || isOnRectangle2 )
        {
            Console.WriteLine ( "border" );
            return;
        }

        Console.WriteLine ( "outside" );
        #endregion
    }
}

