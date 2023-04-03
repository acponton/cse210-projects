using System;

namespace Develop04
{

    public class Mainmenu : Activity
    {

        protected string _response;


        public Mainmenu()
        {
            
        }

        public void DisplayMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            _response = Console.ReadLine();
        }

        public string GetResponse()
        {
            return _response;
        }

    }


}