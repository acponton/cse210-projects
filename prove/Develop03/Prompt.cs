using System;

public class Prompt
{
    private string _response;


    public Prompt()
    {

    }

    public string GetResponse()
    {
        Console.WriteLine($"Press enter to continue or type 'quit' to finish: ");
        _response = Console.ReadLine();

        return _response;
    }
}

