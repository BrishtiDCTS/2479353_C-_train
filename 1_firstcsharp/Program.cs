using System;

namespace UserInfoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

    
            Console.Write("Enter your salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());

       
            Console.WriteLine($"Hello {name}! You are {age} years old and your salary is {salary:C}.");
            
            
        }
    }
}
