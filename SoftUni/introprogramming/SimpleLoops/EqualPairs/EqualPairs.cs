using System;

class EqualPairs
{
    public static void Main ( string[] args )
    {
        int tuplesCount = int.Parse ( Console.ReadLine () );
        int maxDiff = 0;

        int prevSum = 0;

        {
            int firstNumber = int.Parse ( Console.ReadLine () );
            int secondNumber = int.Parse ( Console.ReadLine () );

            prevSum = firstNumber + secondNumber;
        }

        for ( int i = 1; i < tuplesCount; i++ )
        {
            int firstNumber = int.Parse ( Console.ReadLine () );
            int secondNumber = int.Parse ( Console.ReadLine () );

            int sum = firstNumber + secondNumber;
            int diff = Math.Abs ( sum - prevSum );

            if ( diff > maxDiff )
            {
                maxDiff = diff;
            }

            prevSum = sum;
        }

        if ( maxDiff == 0 )
        {
            Console.WriteLine ( "Yes, value={0}", prevSum );
        }
        else
        {
            Console.WriteLine ( "No, maxdiff={0}", maxDiff );
        }
    }
}