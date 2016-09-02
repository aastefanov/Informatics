using System;
using System.Collections.Generic;

namespace IncreasingElements
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> input = new List<int>();
            for (int i = 0; i < n; i++)
            {
                input.Add(int.Parse(Console.ReadLine()));
            }

            int maxCont = 0;
            int maxElem = int.MinValue;

            int cont = 0;
            foreach (int number in input)
            {
                if (number > maxElem)
                {
                    cont++;
                }
                else
                {
                    cont = 1;
                }

                if (cont > maxCont)
                {
                    maxCont = cont;
                }
                maxElem = number;
            }

            Console.WriteLine(maxCont);
        }
    }
}