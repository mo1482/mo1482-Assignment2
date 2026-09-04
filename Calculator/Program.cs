using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            double num1 = ReadNumber("Enter first number: ");
            double num2 = ReadNumber("Enter second number: ");

            Console.WriteLine();
            Console.WriteLine("Choose operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

            Console.Write("Enter choice: ");

            int choice;

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid operation.");
                continue;
            }

            double result;

            switch (choice)
            {
                case 1:
                    result = num1 + num2;
                    Console.WriteLine($"Result = {result}");
                    break;

                case 2:
                    result = num1 - num2;
                    Console.WriteLine($"Result = {result}");
                    break;

                case 3:
                    result = num1 * num2;
                    Console.WriteLine($"Result = {result}");
                    break;

                case 4:

                    if (num2 == 0)
                    {
                        Console.WriteLine("Cannot divide by zero.");
                    }
                    else
                    {
                        result = num1 / num2;
                        Console.WriteLine($"Result = {result}");
                    }

                    break;

                default:
                    Console.WriteLine("Invalid operation.");
                    break;
            }

            Console.WriteLine();

            Console.Write("Do you want another calculation? (y/n): ");

            string answer = Console.ReadLine();

            if (answer.ToLower() != "y")
            {
                break;
            }

            Console.WriteLine();
        }

        Console.WriteLine("Goodbye!");
    }

    static double ReadNumber(string message)
    {
        while (true)
        {
            Console.Write(message);

            if (double.TryParse(Console.ReadLine(), out double number))
            {
                return number;
            }

            Console.WriteLine("Invalid number. Please try again.");
        }
    }
}