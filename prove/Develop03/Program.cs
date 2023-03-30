using System;

class Program
{
    static void Main(string[] args)
    {

        Reference ref1 = new Reference("John", "3", "16");
        Console.WriteLine(ref1.GetReference());
        Word word = new Word();
        word.ShowScripture();
        Prompt prompt = new Prompt();
        Console.WriteLine("");
        Console.WriteLine(prompt.DisplayPrompt());
        string response = Console.ReadLine();

        while (response != "quit")
        {
            Console.Clear();
            ref1.GetReference();
            word.Hidden();
            Console.WriteLine(prompt.DisplayPrompt());
            response = Console.ReadLine();
        }

        Console.WriteLine("Well done, you've memorized it!");
        
    }

    
}