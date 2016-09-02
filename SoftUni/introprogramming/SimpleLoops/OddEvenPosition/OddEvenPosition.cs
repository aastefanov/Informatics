using System;


class OddEvenPosition
{
    public static void Main ( string[] args )
    {
        double numbersCount = double.Parse ( Console.ReadLine () );

        double oddSum = 0;
        double oddMin = double.MaxValue;
        double oddMax = double.MinValue;
        double evenSum = 0;
        double evenMin = double.MaxValue;
        double evenMax = double.MinValue;

        bool oddExists = ( numbersCount >= 1.0 );
        bool evenExists = ( numbersCount >= 2.0 );

        for ( int i = 1; i <= numbersCount; i++ )
        {
            double currentNumber = double.Parse ( Console.ReadLine () );
            if ( i % 2 == 0 ) // even
            {
                evenSum += currentNumber;

                if ( currentNumber > evenMax )
                {
                    evenMax = currentNumber;
                }

                if ( currentNumber < evenMin )
                {
                    evenMin = currentNumber;
                }
            }
            else //odd
            {
                oddSum += currentNumber;

                if ( currentNumber > oddMax )
                {
                    oddMax = currentNumber;
                }

                if ( currentNumber < oddMin )
                {
                    oddMin = currentNumber;
                }
            }
        }

        #region Odd
        Console.WriteLine ( "OddSum={0}", oddSum );
        string oddMinAsString = ( !oddExists ? "No" : oddMin.ToString () );
        string oddMaxAsString = ( !oddExists ? "No" : oddMax.ToString () );

        Console.WriteLine ( "OddMin={0}", oddMinAsString );
        Console.WriteLine ( "Oddmax={0}", oddMaxAsString );
        #endregion

        #region Even
        Console.WriteLine ( "EvenSum={0}", evenSum );
        string evenMinAsString = ( !evenExists ? "No" : evenMin.ToString () );
        string evenMaxAsString = ( !evenExists ? "No" : evenMax.ToString () );

        Console.WriteLine ( "EvenMin={0}", evenMinAsString );
        Console.WriteLine ( "EvenMax={0}", evenMaxAsString );
        #endregion
    }
}
