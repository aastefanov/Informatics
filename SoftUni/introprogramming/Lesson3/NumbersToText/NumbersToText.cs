using System;

class NumbersToText
{
    public static void Main ( string[] args )
    {
        int digit = int.Parse ( Console.ReadLine () );
        string numberAsText;
        switch ( digit )
        {
            case 1:
                numberAsText = "One";
                break;
            case 2:
                numberAsText = "Two";
                break;
            case 3:
                numberAsText = "Three";
                break;
            case 4:
                numberAsText = "Four";
                break;
            case 5:
                numberAsText = "Five";
                break;
            case 6:
                numberAsText = "Six";
                break;
            case 7:
                numberAsText = "Seven";
                break;
            case 8:
                numberAsText = "Eight";
                break;
            case 9:
                numberAsText = "Nine";
                break;
            default:
                numberAsText = "Number too big";
                break;
        }
        Console.WriteLine ( numberAsText );
    }
}

