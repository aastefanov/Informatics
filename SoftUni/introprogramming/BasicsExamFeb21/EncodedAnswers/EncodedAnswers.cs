using System;
using System.Text;

class EncodedAnswers
{
    public static void Main ( string[] args )
    {
        uint questionsCount = uint.Parse ( Console.ReadLine () );
        uint countA = 0;
        uint countB = 0;
        uint countC = 0;
        uint countD = 0;
        StringBuilder answers = new StringBuilder ();

        for ( uint i = 0; i < questionsCount; i++ )
        {
            uint answer = uint.Parse ( Console.ReadLine () );
            switch ( answer % 4 )
            {
                case 0:
                    answers.Append ( "a " );
                    countA++;
                    break;
                case 1:
                    answers.Append ( "b " );
                    countB++;
                    break;
                case 2:
                    answers.Append ( "c " );
                    countC++;
                    break;
                case 3:
                    answers.Append ( "d " );
                    countD++;
                    break;
            }
        }

        /** Removes the trailing whitespace */
        answers.Length--;

        Console.WriteLine ( answers.ToString () );
        Console.WriteLine ( "Answer A: {0}", countA );
        Console.WriteLine ( "Answer B: {0}", countB );
        Console.WriteLine ( "Answer C: {0}", countC );
        Console.WriteLine ( "Answer D: {0}", countD );
    }
}
