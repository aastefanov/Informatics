using System;

class NumberScore
{
    public static void Main ( string[] args )
    {
        double score = double.Parse ( Console.ReadLine () );
        double bonus = 0;
        double newscore = 0;

        if ( score <= 100 )
        {
            bonus += 5d;
        }
        else if ( score > 1000 )
        {
            bonus += 0.1d * score;
        }
        else
        {
            bonus += 0.2d * score;
        }

        if ( score % 2 == 0 )
        {
            bonus += 1d;
        }
        if ( score % 10 == 5 )
        {
            bonus += 2d;
        }

        newscore = bonus + score;

        Console.WriteLine ("{0}\n{1}", bonus, newscore);
        
    }
}

