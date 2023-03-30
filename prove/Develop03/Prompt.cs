using System;

public class Prompt
{
    private string _response;


    public Prompt()
    {

    }

    public string DisplayPrompt()
    {
        Console.WriteLine($"Press enter to continue or type 'quit' to finish:");
        _response = Console.ReadLine();
        return _response;
    }

    public string GetResponse()
    {
        return _response;
    }
}

