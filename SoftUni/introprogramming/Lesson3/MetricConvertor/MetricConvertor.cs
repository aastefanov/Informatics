using System;
using System.Collections.Generic;

class MetricConvertor
{
    public static void Main ( string[] args )
    {
        Dictionary <string, double> metrics = new Dictionary <string,double> ();
        metrics.Add ( "m", 1 );
        metrics.Add ( "mm", 1000 );
        metrics.Add ( "cm", 100 );
        metrics.Add ( "mi", 0.000621371192 );
        metrics.Add ( "in", 39.3700787 );
        metrics.Add ( "km", 0.001 );
        metrics.Add ( "ft", 3.2808399 );
        metrics.Add ( "yd", 1.0936133 );
        double value = double.Parse ( Console.ReadLine () );
        string valueFrom = Console.ReadLine ().ToLower ();
        string valueTo = Console.ReadLine ().ToLower ();

        value /= metrics [ valueFrom ];
        value *= metrics [ valueTo ];
        Console.WriteLine (value);
    }
}
