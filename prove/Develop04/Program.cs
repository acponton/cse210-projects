using System;

namespace Develop04
{

class Program
{
    static void Main(string[] args)
    {
        
      
        string _option = "0";

        while (_option != "quit")
        {
            Mainmenu menu = new Mainmenu();
            menu.DisplayMenu();
            _option = menu.GetResponse();


            if (_option == "1")
            {
                Breathing breathing = new Breathing();
                breathing.SetNameActivity("Breathing");
                breathing.DisplayStartingMessage();
                breathing.DisplayMessage();
                breathing.SetTime();

            }
        }

        
    }
}
}