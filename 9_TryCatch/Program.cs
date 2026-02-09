using System;

class Program {
    static void Main() {
        try {
            Console.Write("Enter Numerator: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Denominator: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int result = a / b;
            Console.WriteLine("Result: "+result);
        }
        catch (DivideByZeroException) {
            Console.WriteLine("Error: Cannot divide by zero.");
        }
        catch (FormatException) {
            Console.WriteLine("Error: Please enter valid numbers.");
        }
    }
}