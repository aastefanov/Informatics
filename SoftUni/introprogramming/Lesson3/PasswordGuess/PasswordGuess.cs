using System;

class PasswordGuess
{
    public static void Main ( string[] args )
    {
        string correctPassword = "s3cr3t!P@ssw0rd";
        string userPassword = Console.ReadLine ();

        if ( correctPassword == userPassword )
        {
            Console.WriteLine ( "Welcome" );
        }
        else
        {
            Console.WriteLine ( "Wrong password!" );
        }
    }
}

