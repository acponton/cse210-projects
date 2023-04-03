using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    public static void Main(string[] args)
    {

        // List<string> _entries = new List<string>()
        // {
            
        // };

        Messages messages = new Messages();
        messages.ShowWelcomeMessage();
        
        string choice = "0";

        while (choice != "5")
        {
          
            Menu menu = new Menu();
            menu.DisplayMenu();
            choice = Console.ReadLine();

        if (choice == "1") //Working
        {
            // Entry entry = new Entry();
            // string _date = entry.SetDate();
            Journal journal = new Journal();
            journal.SetJournal();
            

            // PromptGenerator generator = new PromptGenerator();
            // var _prompt = generator.RandomPrompts();
            // Console.Write(_prompt);
            // string _answer = Console.ReadLine();
            // string _record = ($"{_date}, {_prompt}, {_answer}");
            // Journal journal = new Journal();
            // _entries.Add(_record);
        }

        if (choice == "2") 
        {
            // foreach(string _record in _entries){

            //     Console.WriteLine(_record);
            // }
            Journal journal = new Journal();
            journal.GetJournal();
        }

        if (choice == "3") //Working
        
        {
            Journal journal = new Journal();
            journal.SelectFile();
            journal.ShowFile();   
        }

        if (choice == "4")
        {
            Journal journal = new Journal();
            journal.SaveFile();
            journal.SuccesfullySaved();
            // Console.Write("Enter a filename (.txt): ");
            // string _fileName = Console.ReadLine();
            // foreach(string _record in _entries)
            // {
            //     System.IO.File.WriteAllText(_fileName, _record);
            // }
            
        }
        }
        messages.ShowEndingMessage();

    } 
}