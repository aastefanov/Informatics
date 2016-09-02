using System;

class Cinema
{
    public static void Main ( string[] args )
    {
        string typeAsString = Console.ReadLine ().ToLower ();

        decimal typePrice = 0m;
        switch ( typeAsString )
        {
            case "premiere":
                typePrice = 12m;
                break;
            case "normal":
                typePrice = 7.5m;
                break;
            case "discount":
                typePrice = 5m;
                break;
            default:
                break;
        }

        decimal rows = int.Parse ( Console.ReadLine () );
        decimal cols = int.Parse ( Console.ReadLine () );

        decimal income = typePrice * rows * cols;

        Console.WriteLine ("{0:f2}", income);
    }
}
