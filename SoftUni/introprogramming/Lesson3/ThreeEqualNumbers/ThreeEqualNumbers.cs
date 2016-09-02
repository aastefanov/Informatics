using System;

class ThreeEqualNumbers
{
    public static void Main ( string[] args )
    {
        double firstNumber = double.Parse ( Console.ReadLine () );
        double secondNumber = double.Parse ( Console.ReadLine () );
        double thirdNumber = double.Parse ( Console.ReadLine () );

        if ( firstNumber == secondNumber && secondNumber == thirdNumber )
        {
            Console.WriteLine ( "Yes" );
        }
        else
        {
            Console.WriteLine ( "No" );
        }
    }
}
