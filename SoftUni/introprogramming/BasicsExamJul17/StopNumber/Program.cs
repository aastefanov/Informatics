using System;

class StopNumber
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int s = int.Parse(Console.ReadLine());

        // Make sure M can be divided by 6
        m = (m / 6) * 6;

        for (int i = m; i >= n; i -= 6)
        {
            if (i == s)
            {
                break;
            }
            Console.Write(i + " ");
        }
    }
}