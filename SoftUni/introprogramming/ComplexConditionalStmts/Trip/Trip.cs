using System;
using System.Text;

class Trip
{
    public static void Main ( string[] args )
    {
        decimal budget = decimal.Parse ( Console.ReadLine () );
        string season = Console.ReadLine ();

        StringBuilder output = new StringBuilder();

        bool isSummer;
        if ( season == "summer" )
        {
            isSummer = true;
        }
        else
        {
            isSummer = false;
        }

        // Bulgaria
        if(budget<=100)
        {
            output.AppendLine ("Somewhere in Bulgaria");
            if ( isSummer )
            {
                budget *= 0.3m;
                output.AppendFormat("Camp - {0:0.00}", budget);
            }
            else
            {
                budget *= 0.7m;
                output.AppendFormat("Hotel - {0:0.00}", budget);
            }
            output.AppendLine ();
        }
        //Balkans
        else if(budget<=1000)
        {
            output.AppendLine ("Somewhere in Balkans");
            if ( isSummer )
            {
                budget *= 0.4m;
                output.AppendFormat("Camp - {0:0.00}", budget);
            }
            else
            {
                budget *= 0.8m;
                output.AppendFormat("Hotel - {0:0.00}", budget);
            }
            output.AppendLine ();
        }
        //Europe
        else
        {
            output.AppendLine ("Somewhere in Europe");
            budget *= 0.9m;
            output.AppendFormat("Hotel - {0:0.00}", budget);
            output.AppendLine ();
        }

        Console.WriteLine (output);
    }
}
