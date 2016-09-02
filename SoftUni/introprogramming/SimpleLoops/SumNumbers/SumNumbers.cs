using System;

namespace SumNumbers
{
    class SumNumbers
    {
        public static void Main ( string[] args )
        {
            int numbersCount = int.Parse ( Console.ReadLine () );
            int sum = 0;

            for ( int i = 0; i < numbersCount; i++ )
            {
                sum += int.Parse ( Console.ReadLine () );
            }

            Console.WriteLine ( sum );
        }
    }
}
