using System;

namespace Develop05
{
class Program
{
    static void Main(string[] args)
    {
        string _option = "0";

        while (_option != "6")
        {
            Mainmenu menu = new Mainmenu();
            menu.DisplayMenu();
            _option = menu.GetResponse();
            Console.Clear();


            if (_option == "1")
            {
                
            }

            if (_option == "2")
            {
                
            }

            if (_option == "3")
            {
               
            }


        }
    }
}
}