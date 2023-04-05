using System;

namespace Develop04
{

    public class Activity
    {
        protected string _startingMessage;
        protected string _endingMessage;
        protected string _nameActivity;
        protected int _duration; 


        public Activity()
        {

        }

        public void SetNameActivity(string nameActivity)
        {
            _nameActivity = nameActivity;
        }

        public string GetNameActivity()
        {
            return _nameActivity;
        }

        public void DisplayStartingMessage()
        {
            Console.WriteLine("");
            Console.WriteLine($"Welcome to the {_nameActivity} Activity.");
            Console.WriteLine("");
        }

        public int SetTime()
        {
            Console.WriteLine("");
            Console.WriteLine($"How long, in seconds, would you like for your session? ");
            _duration = Int32.Parse(Console.ReadLine());
            return _duration;
        }

        public int GetTime()
        {
            return _duration;
        }

        public void DisplayMessageReady()
        {
            Console.WriteLine("Get ready...");
        }

        public void DisplayMessageWellDone()
        {
            Console.WriteLine("");
            Console.WriteLine("Well done!!");
        }

        public void DisplayMessageExtraSecondsCompleted()
        {
            Console.WriteLine("");
            Console.WriteLine($"You have completed another {_duration} seconds of the {_nameActivity}.");
        }

        public void GetReadySpinner()
        {
            for(int x = 0; x < 5; x++)
            {
                Console.Write("|");
                Thread.Sleep(300);
                Console.Write("\b \b");
                Console.Write("/");
                Thread.Sleep(300);
                Console.Write("\b \b");
                Console.Write("-");
                Thread.Sleep(300);
                Console.Write("\b \b");
            }

        }

        public void GetMayBegin()
        {
            for(int x = 0; x < 5; x++)
            {
                Console.Write("You may begin in : 4");
                Thread.Sleep(300);
                Console.Write("\b \b");
                x++;
                Console.Write("3");
                Thread.Sleep(300);
                Console.Write("\b \b");
                x++;
                Console.Write("2");
                Thread.Sleep(300);
                Console.Write("\b \b");
                x++;
                Console.Write("1");
                Thread.Sleep(300);
                Console.Write("\b \b");
                x++;
            }
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