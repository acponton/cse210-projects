using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string inputName = PromptUserName( );

        int inputNumber = PromptUserNumber();

        int Squared = SquareNumber(inputNumber);

        DisplayResult(inputName, Squared);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine();
        Console.WriteLine("Welcome to the program!");
        Console.WriteLine();
    }

    static string PromptUserName()
    {
        Console.Write("Please, enter your name: ");
        string name = Console.ReadLine();

        return name;
    }
    
    static int PromptUserNumber()
    {
        Console.Write("Please, enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;

        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine();
        Console.WriteLine($"{name}, the square of your number is {square}.");
        Console.WriteLine();
    }


}
