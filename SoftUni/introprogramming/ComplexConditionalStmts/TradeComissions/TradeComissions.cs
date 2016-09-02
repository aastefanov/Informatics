using System;
using System.Collections.Generic;

class TradeComissions
{
    public static void Main ( string[] args )
    {
        string city = Console.ReadLine ();
        decimal sales = decimal.Parse ( Console.ReadLine () );

        if ( !( ( city == "Sofia" || city == "Plovdiv" || city == "Varna" ) && sales >= 0 ) )
        {
            Console.WriteLine ( "error" );
            return;
        }

        int comissionplan;

        if ( sales <= 500 )
        {
            comissionplan = 0;
        }
        else if ( sales <= 1000 )
        {
            comissionplan = 1;
        }
        else if ( sales <= 10000 )
        {
            comissionplan = 2;
        }
        else
            comissionplan = 3;

        Dictionary<string, Dictionary<int, decimal> > cities = new Dictionary<string, Dictionary<int,decimal> > ();

        // Set prices
        {
            Dictionary <int,decimal> prices = new Dictionary<int,decimal> ();

            // Sofia
            {
                prices.Add ( 0, 0.05m );
                prices.Add ( 1, 0.07m );
                prices.Add ( 2, 0.08m );
                prices.Add ( 3, 0.12m );

                cities.Add ( "Sofia", new Dictionary<int, decimal> ( prices ) );

                prices.Clear ();
            }

            // Plovdiv
            {
                prices.Add ( 0, 0.055m );
                prices.Add ( 1, 0.08m );
                prices.Add ( 2, 0.12m );
                prices.Add ( 3, 0.145m );

                cities.Add ( "Plovdiv", new Dictionary<int, decimal> ( prices ) );

                prices.Clear ();
            }

            // Varna
            {
                prices.Add ( 0, 0.045m );
                prices.Add ( 1, 0.075m );
                prices.Add ( 2, 0.1m );
                prices.Add ( 3, 0.13m );

                cities.Add ( "Varna", new Dictionary<int, decimal> ( prices ) );

                prices.Clear ();
            }
        }

        decimal comission = cities [ city ] [ comissionplan ];

        Console.WriteLine ( "{0:f2}", comission * sales );
    }
}
