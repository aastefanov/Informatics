using System;

class Number100To200
{
    public static void Main ( string[] args )
    {
        int numberToCheck = int.Parse ( Console.ReadLine () );

        if ( numberToCheck < 100 )
        {
            Console.WriteLine ( "Less than 100" );
        }
        else if ( numberToCheck > 200 )
        {
            Console.WriteLine ( "Greater than 200" );
        }
        else
        {
            Console.WriteLine ( "Between 100 and 200" );
        }
    }
}

