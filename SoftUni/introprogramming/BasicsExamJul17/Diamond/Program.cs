using System;

class Diamond
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        #region Top

        Console.WriteLine(
            new string('.', n) +
            new string('*', 3 * n) +
            new string('.', n)
            );

        for (int i = n - 1; i >= 1; i--)
        {
            Console.WriteLine(
                new string('.', i) + "*" +
                new string('.', (5 * n - 2 * i - 2)) +
                "*" + new string('.', i)
                );
        }
        #endregion

        #region Middle
        Console.WriteLine(new string('*', 5 * n));
        #endregion


        #region Bottom

        for (int i = 1; i <= 2 * n; i++)
        {
            Console.WriteLine(
                new string('.', i) + "*" +
                new string('.', (5 * n - 2 * i - 2)) +
                "*" + new string('.', i)
                );
        }

        Console.WriteLine(
            new string('.', 2 * n + 1) +
            new string('*', n - 2) +
            new string('.', 2 * n + 1)
            );
        #endregion

    }
}