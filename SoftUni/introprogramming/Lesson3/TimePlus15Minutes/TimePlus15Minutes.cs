using System;

class TimePlus15Minutes
{
    public static void Main ( string[] args )
    {
        int hours = int.Parse ( Console.ReadLine () );
        int minutes = int.Parse ( Console.ReadLine () );

        minutes += 15;

        if ( minutes >= 60 )
        {
            minutes -= 60;
            hours++;
        }

        if ( hours >= 24 )
        {
            hours -= 24;
        }

        Console.WriteLine ( "{0}:{1:00}", hours, minutes );
    }
}
