using System;

namespace EnterEvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            input:
            Console.WriteLine("Enter even number:");
            string numberAsString = Console.ReadLine();
            int number;
            bool numberValid = int.TryParse(numberAsString, out number);
                
            if (number%2 != 0 || !numberValid)
            {
                Console.WriteLine("The number is not even");
                goto input;
            }

            Console.WriteLine("Even number entered: {0}", number);
        }
    }
}
