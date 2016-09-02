using System;

class DayOfWeek
{
    public static void Main ( string[] args )
    {
        int dayOfWeek = int.Parse ( Console.ReadLine () );

       
        string dayOfWeekAsString;

        switch ( dayOfWeek )
        {
            case 1:
                dayOfWeekAsString = "Monday";
                break;
            case 2:
                dayOfWeekAsString = "Tuesday";
                break;
            case 3:
                dayOfWeekAsString = "Wednesday";
                break;
            case 4:
                dayOfWeekAsString = "Thursday";
                break;
            case 5:
                dayOfWeekAsString = "Friday";
                break;
            case 6:
                dayOfWeekAsString = "Saturday";
                break;
            case 7:
                dayOfWeekAsString = "Sunday";
                break;
            default:
                dayOfWeekAsString = "Error";
                break;
        }

        Console.WriteLine ( dayOfWeekAsString );
    }
}
