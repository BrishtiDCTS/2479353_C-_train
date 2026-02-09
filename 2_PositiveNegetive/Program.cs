using System;

namespace NumberChecker
{
    class Program
    {
        static void Main(string[] args)
        {
      
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            int number = Convert.ToInt32(input);

            if (number > 0)
            {
                Console.WriteLine($"{number} is a Positive number.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"{number} is a Negative number.");
            }
            else
            {
                Console.WriteLine("The number is Zero.");
            }
        }
    }
}