using System;

class Program
{
    static void Main(string[] args)
    {
        Reference ref1 = new Reference("John", "3", "16");
        Console.WriteLine(ref1.GetReference());

        Scripture scripture = new Scripture();
        Console.WriteLine(scripture.GetFullScripture());
        
        Prompt prompt = new Prompt();
        Console.WriteLine(prompt.GetResponse());

    }
}