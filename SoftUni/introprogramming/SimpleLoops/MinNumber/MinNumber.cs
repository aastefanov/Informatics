﻿using System;

class MinNumber
{
    public static void Main ( string[] args )
    {
        int numbersCount = int.Parse ( Console.ReadLine () );

        int minNumber = int.MaxValue;
        for ( int i = 0; i < numbersCount; i++ )
        {
            int currentNumber = int.Parse ( Console.ReadLine () );

            if ( currentNumber > minNumber )
            {
                minNumber = currentNumber;
            }

        }

        Console.WriteLine ( minNumber );
    }
}
