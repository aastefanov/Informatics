using System;
using System.Text;

class TriangleOfDollars
{
    public static void Main ( string[] args )
    {

        int n = int.Parse ( Console.ReadLine () );
        StringBuilder dollars = new StringBuilder("$");

        for ( int i = 0; i < n; i++ )
        {
            Console.WriteLine (dollars);
            dollars.Append (" $");
        }
    }
}
