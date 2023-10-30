using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Minimal .NET Console App!");
        
        while (true)
        {
            Console.WriteLine("\nPlease select an option:");
            Console.WriteLine("1. Say Hello");
            Console.WriteLine("2. Exit");
            
            string choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    SayHello();
                    break;
                case "2":
                    Console.WriteLine("Goodbye!");
                    return; // Exit the application
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void SayHello()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine($"Hello, {name}!");
    }
}
