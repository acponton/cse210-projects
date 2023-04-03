using System;

namespace Develop04
{

    public class Activity
    {
        protected string _startingMessage;
        protected string _endingMessage;
        protected string _nameActivity;
        protected string _duration; 


        public Activity()
        {

        }

        public void SetNameActivity(string nameActivity)
        {
            _nameActivity = nameActivity;
        }

        public void DisplayStartingMessage()
        {
            Console.WriteLine("");
            Console.WriteLine($"Welcome to the {_nameActivity} Activity.");
            Console.WriteLine("");
        }

        public void SetTime()
        {
            Console.WriteLine("");
            Console.WriteLine($"How long, in seconds, would you like for your session? ");
            _duration = Console.ReadLine();
            Console.WriteLine("");
        }

        public string GetTime()
        {
            return _duration;
        }
        public void DisplayEndingMessage()
        {

        }

        public void PausingSpinner()
        {

        }

        public void PausingCountdown()
        {

        }

        public void RunActivity()
        {

        }




    }




}