﻿using System;

class ExcellentOrNot
{
    public static void Main ( string[] args )
    {
        double grade = double.Parse ( Console.ReadLine () );
        if ( grade >= 5.50 )
        {
            Console.WriteLine ( "Excellent!" );
        }
        else
        {
            Console.WriteLine ( "Not excellent." );
        }
    }
}
