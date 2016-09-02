using System;

internal class SaltAndPepper
{
    public static void Main(string[] args)
    {
        ulong inputNumber = ulong.Parse(Console.ReadLine());

        do
        {
            string answer = Console.ReadLine();
            if (answer == "end")
            {
                break;
            }

            string[] words = answer.Split(' ');
            bool mask = words[0] == "salt" ? true : false;
            int step = int.Parse(words[1]);

            if (mask)
            {
                for (int i = 0; i <= 63; i += step)
                {
                    if (((inputNumber >> i) & 1) != 1) continue;
                    ulong maskUlong = ~((ulong)1 << i);
                    inputNumber = inputNumber & maskUlong;
                }
            }
            else
            {
                for (int i = 0; i <= 63; i += step)
                {
                    if (((inputNumber >> i) & 1) != 0) continue;
                    ulong maskUlong = (ulong)1 << i;
                    inputNumber = inputNumber | maskUlong;
                }
            }


        } while (true);


        Console.WriteLine(inputNumber);

    }
}