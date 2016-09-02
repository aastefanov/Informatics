using System;

namespace NumberTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine())+1;

            for (int i = 1; i < n; i++)
            {
                bool isToN = false;
                int k = i;
                for (int j = 1; j<n; j++)
                {
                    
                    if (k == n - 1)
                    {
                        isToN = true;
                    }

                    Console.Write(k + " ");

                    if (isToN)
                    {
                        k--;
                    }
                    else
                    {
                        k++;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
