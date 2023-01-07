using System;

class Program
{
    static void Main(string[] args)
    {
        string letter = "";

        Console.WriteLine();
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int grade_percentage = int.Parse(userInput);
        
        if (grade_percentage >= 90)
        {
            letter = "A";
        }
        else if (grade_percentage >= 80)
        {
            letter = "B";
        }
        else if (grade_percentage >= 70)
        {
            letter = "C";
        }
        else if (grade_percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine();
        Console.WriteLine ($"Your grade is {letter}.");

        if (grade_percentage >= 70)
        {
            Console.WriteLine("Congratulations, you did it!");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Keep doing your best, next time will be better.");
            Console.WriteLine();
        }
    }
}