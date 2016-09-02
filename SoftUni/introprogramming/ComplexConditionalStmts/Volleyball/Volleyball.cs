using System;

class Volleyball
{
    public static void Main ( string[] args )
    {

        #region Input

        bool isLeapYear = ( Console.ReadLine ().ToLower () == "leap" );
        double holidays = double.Parse ( Console.ReadLine () );
        double villageWeekends = double.Parse ( Console.ReadLine () );

        #endregion

        #region Played Weekends

        double weekendsAvailable = 48.0;

        double sofiaWeekends = weekendsAvailable - villageWeekends;
        double sofiaPlayed = sofiaWeekends * 0.75;

        double villagePlayed = villageWeekends;

        #endregion

        #region Played Holidays
        double holidayPlayed = holidays * ( 2.0 / 3.0 );
        #endregion


        double allPlayed = sofiaPlayed + villagePlayed + holidayPlayed;

        if ( isLeapYear )
        {
            allPlayed *= 1.15;
        }

        Console.WriteLine ( "{0:0}", Math.Floor ( allPlayed ) );
    }
}