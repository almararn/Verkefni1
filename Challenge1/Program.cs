using System;
using System.Collections.Generic;
using System.Linq;

namespace challenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myNumbers = new List<int>();
            bool check = true;
            string input;
            int number;

            while (check)
            {
                Console.WriteLine("Please enter your numbers, and press 'ENTER' when finished.");
                Console.Write("Input: ");
                input = Console.ReadLine();
                check = int.TryParse(input, out number);
                if (check)
                {
                    myNumbers.Add(number);
                }
            }

            if (myNumbers.Count != 0)
            {
                Console.WriteLine($"You entered {myNumbers.Count()} numbers successfully, with the highest value of {myNumbers.Max()} and the lowest value of {myNumbers.Min()}.");
            }
            else
            {
                Console.WriteLine("You didn't enter any valid numbers. Exiting program.");
            }

        }
    }
}