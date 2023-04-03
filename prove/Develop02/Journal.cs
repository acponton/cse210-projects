using System;
using System.Collections.Generic;

public class Journal
{
    public string _date;
    public string _prompt;
    public string _answer;
    public string _record;
    public string _file;
    public string _fileName;

    List<string> _entries = new List<string>()
    {

    };

    public Journal()
    {

    }
    // public Journal(string _date, string _prompt, string _answer) 
    // {

    // }

    public void SetJournal()
    { 
        Entry entry = new Entry();
        string _date = entry.SetDate();

        PromptGenerator generator = new PromptGenerator();
        var _prompt = generator.RandomPrompts();
        Console.Write(_prompt);
        string _answer = Console.ReadLine();
        string _record = $"{_date}, {_prompt}, {_answer}";
        // Entry entry = new Entry();
        _entries.Add(_record);
        
    }

    public void GetJournal()
    {
        foreach(string _record in _entries)
        {
            // Entry entry = new Entry();   
            // _date = entry.SetDate();
            Console.WriteLine(_record);
        }
    }

    public string SelectFile()
    {
        Console.Write("Enter a filename to load from, .txt: ");
        string _file = Console.ReadLine();
        return _file;
    }
    
    public void ShowFile()
    {
        string[] _lines = System.IO.File.ReadAllLines(_file);
        foreach(string _line in _lines)
        {
            string[] columns = _line.Split(",");
            string _date = columns[0];
            string _prompt = columns[1];
            string _answer = columns[2];
            Console.WriteLine($"Date: {_date}, Prompt: {_prompt} Entry: {_answer}");
        }
    }

    public void SaveFile()
    {
        Console.Write("Enter a filename (.txt): ");
        string _fileName = Console.ReadLine();
        
        foreach(string _record in _entries)
        {
            System.IO.File.WriteAllText(_fileName, _record);
        }
    }

    public void SuccesfullySaved()
    {
        Console.WriteLine("Your file has been succesfully saved!");
    }

            
}
