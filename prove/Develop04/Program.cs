using System;

namespace Develop04
{

class Program
{
    static void Main(string[] args)
    {
        
      
        string _option = "0";

        while (_option != "4")
        {
            Mainmenu menu = new Mainmenu();
            menu.DisplayMenu();
            _option = menu.GetResponse();
            Console.Clear();


            if (_option == "1")
            {
                Breathing breathing = new Breathing();
                breathing.SetNameActivity("Breathing");
                breathing.DisplayStartingMessage();
                breathing.DisplayMessage();
                breathing.SetTime();
                Console.Clear();

                Activity activity = new Activity();
                activity.DisplayMessageReady();
                activity.GetReadySpinner();

                Console.Clear();
                activity.DisplayMessageReady();
                breathing.DisplayCountdown();

                activity.DisplayMessageWellDone();
                activity.GetReadySpinner();

                breathing.DisplayMessageExtraSecondsCompleted();
                breathing.GetReadySpinner();
                Console.Clear();
            }

            if (_option == "2")
            {
                Reflecting reflecting = new Reflecting();
                reflecting.SetNameActivity("Reflecting");
                reflecting.DisplayStartingMessage();
                reflecting.DisplayMessage();
                reflecting.SetTime();
                Console.Clear();

                reflecting.DisplayMessageReady();
                reflecting.GetReadySpinner();

                Console.Clear();
                reflecting.DisplayMessageReady();
                Console.WriteLine();
                reflecting.DisplayPrompt1();
                Console.WriteLine();
                reflecting.DisplayPrompt2();
                Console.WriteLine();
                reflecting.GetMayBegin();

                Console.Clear();
                reflecting.DisplayQuestion1();
                reflecting.GetReadySpinner();
                reflecting.DisplayQuestion2();
                reflecting.GetReadySpinner();
                
                Console.WriteLine("");
                reflecting.DisplayMessageWellDone();
                reflecting.GetReadySpinner();

                reflecting.DisplayMessageExtraSecondsCompleted();
                reflecting.GetReadySpinner();
                Console.Clear();
            }

            if (_option == "3")
            {
                Listing listing = new Listing();
                listing.SetNameActivity("Listing");
                listing.DisplayStartingMessage();
                listing.DisplayMessage();
                listing.SetTime();
                Console.Clear();

                listing.DisplayMessageReady();
                listing.GetReadySpinner();

                Console.Clear();
                listing.DisplayMessageReady();
                Console.WriteLine();
                listing.DisplayPrompt1();
                listing.GetMayBegin();
                listing.GetAnswer();
            }


        }

        
    }
}
}