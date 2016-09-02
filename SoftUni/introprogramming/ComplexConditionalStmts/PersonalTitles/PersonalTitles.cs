using System;

class PersonalTitles
{
    public static void Main ( string[] args )
    {
        float age = float.Parse ( Console.ReadLine () );
        char gender = char.Parse ( Console.ReadLine () );
        if ( gender == 'm' )
        {
            if ( age < 16 )
            {
                Console.WriteLine ( "Master" );
            }
            else
            {
                Console.WriteLine ( "Mr." );
            }
        }
        else
        {
            if ( age < 16 )
            {
                Console.WriteLine ( "Miss" );
            }
            else
            {
                Console.WriteLine ( "Ms." );
            }
        }
    }
}
