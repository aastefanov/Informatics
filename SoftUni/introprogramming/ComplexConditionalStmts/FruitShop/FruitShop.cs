using System;
using System.Collections.Generic;

class FruitShop
{
    public static void Main ( string[] args )
    {
        string fruit = Console.ReadLine ().ToLower ();
        string day = Console.ReadLine ().ToLower ();
        decimal quantity = decimal.Parse ( Console.ReadLine () );

        /** Ugly fix */
        if ( day == "workday" )
        {
            Console.WriteLine ( "error" );
            return;
        }

        bool isWeekend;

        if ( day == "saturday" || day == "sunday" )
        {
            isWeekend = true;
        }
        else
        {
            isWeekend = false;
        }

        Dictionary<bool, Dictionary<string,decimal> > prices = new Dictionary<bool, Dictionary<string, decimal> > ();

        Dictionary<string,decimal> tempPrices = new Dictionary<string, decimal> ();
        //Weekday
        {
            tempPrices.Add ( "banana", 2.5m );
            tempPrices.Add ( "apple", 1.2m );
            tempPrices.Add ( "orange", 0.85m );
            tempPrices.Add ( "grapefruit", 1.45m );
            tempPrices.Add ( "kiwi", 2.7m );
            tempPrices.Add ( "pineapple", 5.5m );
            tempPrices.Add ( "grapes", 3.85m );

            prices.Add ( false, new Dictionary<string,decimal> ( tempPrices ) );
            tempPrices.Clear ();
        }

        //Weekend
        {
            tempPrices.Add ( "banana", 2.7m );
            tempPrices.Add ( "apple", 1.25m );
            tempPrices.Add ( "orange", 0.9m );
            tempPrices.Add ( "grapefruit", 1.6m );
            tempPrices.Add ( "kiwi", 3m );
            tempPrices.Add ( "pineapple", 5.6m );
            tempPrices.Add ( "grapes", 4.2m );

            prices.Add ( true, new Dictionary<string,decimal> ( tempPrices ) );
            tempPrices.Clear ();
        }
           
        Console.WriteLine ( getPrice ( prices [ isWeekend ], fruit, quantity ) );
    }

    public static string getPrice ( Dictionary <string,decimal> dict, string key, decimal fruitQuantity )
    {
        if ( !dict.ContainsKey ( key ) )
        {
            return "error";
        }
        return string.Format ( "{0:0.00}", fruitQuantity * dict [ key ] );
    }
}
