using System;

namespace Develop05
{

    public class Mainmenu : Goals
    {

        protected int _response;


        public Mainmenu()
        {

        }

        public void DisplayPoints()
        {
            Console.WriteLine("");
            Console.WriteLine($"You have {_points} points.");
        }

        public int GetResponse()
        {
            return _response;
        }
        public void Displaymenu()
        {
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("Quit");
            Console.WriteLine("Select a choice from the menu: ");
            _response = Int32.Parse(Console.ReadLine());
        }
 
        

    }


}