using System;
using System.Collections.Generic;

class SmallShop
{
    public static void Main ( string[] args )
    {

        string product = Console.ReadLine ();
        string city = Console.ReadLine ();
        decimal quantity = decimal.Parse ( Console.ReadLine () );

        Dictionary<string, Dictionary<string, decimal> > cities = new Dictionary<string, Dictionary<string,decimal> > ();

        // Set prices
        {
            Dictionary <string,decimal> prices = new Dictionary<string,decimal> ();

            // Sofia
            {
                prices.Add ( "coffee", 0.5m );
                prices.Add ( "water", 0.8m );
                prices.Add ( "beer", 1.2m );
                prices.Add ( "sweets", 1.45m );
                prices.Add ( "peanuts", 1.6m );

                cities.Add ( "Sofia", new Dictionary<string, decimal> ( prices ) );

                prices.Clear ();
            }

            // Plovdiv
            {
                prices.Add ( "coffee", 0.4m );
                prices.Add ( "water", 0.7m );
                prices.Add ( "beer", 1.15m );
                prices.Add ( "sweets", 1.3m );
                prices.Add ( "peanuts", 1.5m );

                cities.Add ( "Plovdiv", new Dictionary<string, decimal> ( prices ) );

                prices.Clear ();
            }

            // Varna
            {
                prices.Add ( "coffee", 0.45m );
                prices.Add ( "water", 0.7m );
                prices.Add ( "beer", 1.1m );
                prices.Add ( "sweets", 1.35m );
                prices.Add ( "peanuts", 1.55m );

                cities.Add ( "Varna", new Dictionary<string, decimal> ( prices ) );

                prices.Clear ();
            }
        }

        Console.WriteLine ( quantity * cities [ city ] [ product ] );
    }
}
