using System;

class HalfSumElement
{
    public static void Main ( string[] args )
    {
        int numbersCount = int.Parse ( Console.ReadLine () );
        int maxNumber = int.MinValue;
        int numbersSum = 0;

        for ( int i = 0; i < numbersCount; i++ )
        {
            int currentNumber = int.Parse ( Console.ReadLine () );

            if ( currentNumber > maxNumber )
            {
                maxNumber = currentNumber;
            }

            numbersSum += currentNumber;
        }

        int sumWithoutMax = numbersSum - maxNumber;

        int difference = Math.Abs ( sumWithoutMax - maxNumber );

        if ( difference == 0 )
        {
            Console.WriteLine ( "yes sum {0}", sumWithoutMax );
        }
        else
        {
            Console.WriteLine ( "no diff {0}", difference );
        }
    }
}