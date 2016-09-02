using System;
using System.Text;

class Butterfly
{
    public static void Main ( string[] args )
    {
        int size = int.Parse ( Console.ReadLine () );

        //Upper part
        {
            string asterisksLine = new string ( '*', size - 2 ) + "\\ /" + new string ( '*', size - 2 );
            string dashesLine = new string ( '-', size - 2 ) + "\\ /" + new string ( '-', size - 2 );

            for ( int i = 0; i < size - 2; i++ )
            {
                if ( ( i % 2 ) == 0 )
                {
                    Console.WriteLine ( asterisksLine );
                }
                else
                {
                    Console.WriteLine ( dashesLine );
                }
            }
        }

        //Middle
        Console.WriteLine ( new string ( ' ', size - 1 ) + "@" );

        //Lower part
        {
            string asterisksLine = new string ( '*', size - 2 ) + "/ \\" + new string ( '*', size - 2 );
            string dashesLine = new string ( '-', size - 2 ) + "/ \\" + new string ( '-', size - 2 );

            for ( int i = size - 3; i >= 0; i-- )
            {
                if ( ( i % 2 ) == 0 )
                {
                    Console.WriteLine ( asterisksLine );
                }
                else
                {
                    Console.WriteLine ( dashesLine );
                }
            }
        }
    }
}
