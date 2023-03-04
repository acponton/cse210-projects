using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    public static void Main(string[] args)
    {

    List<string> entries = new List<string>()
    {   
    };

    Console.WriteLine("Welcome to the Journal Program!");
    string choice = "0";
    while (choice != "5"){
        Console.WriteLine("");
        Console.WriteLine("Please, select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.WriteLine("What would you like to do? ");
        Console.WriteLine("");
        choice = Console.ReadLine();

    if (choice == "1") {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        var generator = new promptGenerator();
        var prompt = generator.randomPrompts();
        Console.Write(prompt);
        string answer = Console.ReadLine();
        string record = ($"{dateText}, {prompt}, {answer}");
        entries.Add(record);
    }

    if (choice == "2") {
        foreach(string record in entries){

            Console.WriteLine(record);
        }
    }

    if (choice == "3"){
        Console.Write("Enter a filename to load from, .txt: ");
        string file = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(file);
        foreach(string line in lines)
        {
            string[] columns = line.Split(",");
            string dateText = columns[0];
            string prompt = columns[1];
            string answer = columns[2];
            Console.WriteLine($"Date: {dateText}, Prompt: {prompt} Entry: {answer}");
        }
    }

    if (choice == "4"){
        Console.Write("Enter a filename (.txt): ");
        string fileName = Console.ReadLine();
        foreach(string record in entries)
        {
            System.IO.File.WriteAllText(fileName, record);
        }
        Console.WriteLine("Your file has been succesfully saved!");
        // using (StreamWriter outputFile = new StreamWriter(fileName, true))
        // {
        //     foreach(string record in entries)
        //     {
        //         System.IO.File.WriteAllText(fileName, record);
                
        //     };
        //     Console.WriteLine("Your file has been succesfully saved!");
        // }
        
    }
    }
    Console.WriteLine("Thank you, goodbye.");
    Console.WriteLine("");

    } 
}