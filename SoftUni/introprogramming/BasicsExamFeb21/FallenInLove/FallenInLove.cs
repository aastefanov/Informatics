using System;
using System.Runtime.InteropServices;

class FallenInLove
{
    public static void Main(string[] args)
    {
        int flowerSize = int.Parse(Console.ReadLine());

        #region Top
        int emptySize = 2 * flowerSize;
        for (int i = 0; i < flowerSize; i++)
        {
            Console.WriteLine(
                "#" + new string('~', i) + "#" +
                new string('.', emptySize) + "#" +
                new string('.', i * 2) +
                "#" + new string('.', emptySize) +
                "#" + new string('~', i) + "#"
                );
            emptySize -= 2;
        }
        #endregion

        #region Middle

        emptySize = 2 * flowerSize;
        int j = 1;
        for (int i = flowerSize; i > 0; i--)
        {
            Console.WriteLine(
                new string('.', flowerSize - i + j) +
                "#" + new string('~', i) + "#" +
                new string('.', emptySize) +
                "#" + new string('~', i) + "#" +
                new string('.', flowerSize - i + j)
                );

            emptySize -= 2;
            j += 1;
        }
        #endregion

        #region Bottom

        Console.WriteLine(
            new string('.', 2 * flowerSize + 1) +
            new string('#', 4) +
            new string('.', 2 * flowerSize + 1)
            );
        string bottomEmpty = new string('.', 2 * flowerSize + 2);
        string bottomFull = new string('#', 2);
        string bottomLine = bottomEmpty + bottomFull + bottomEmpty;
        for (int i = 0; i < flowerSize; i++)
        {
            Console.WriteLine(bottomLine);
        }
        #endregion
    }
}

