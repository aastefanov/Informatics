using System;

class SumSeconds
{
    public static void Main ( string[] args )
    {
        int timeOf1 = int.Parse ( Console.ReadLine () );
        int timeOf2 = int.Parse ( Console.ReadLine () );
        int timeOf3 = int.Parse ( Console.ReadLine () );

        int mutualTime = timeOf1 + timeOf2 + timeOf3;

        int mutualMinutes = mutualTime / 60;
        int mutualSeconds = mutualTime % 60;

        Console.WriteLine ("{0:D1}:{1:D2}", mutualMinutes, mutualSeconds);
    }
}
