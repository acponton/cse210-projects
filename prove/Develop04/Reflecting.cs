using System;

namespace Develop04
{

    public class Reflecting : Activity
    {

        protected string _name; 
        protected string _description;
        protected string _answer;
        List<string> _prompt = new List<string>();
        List<string> _question = new List<string>();

        public Reflecting()
        {


        }

        public void DisplayMessage()
        {
            Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
            Console.WriteLine("");
        }        

        public void GetRandomPrompt()
        {

        }

        public void DisplayQuestion1()
        {
            Console.WriteLine("> How did you feel when it was complete?");
        }

        public void DisplayQuestion2()
        {
            Console.WriteLine("> What is your favorite thing about this experience?");
        }

        public string DisplayPrompt1()
        {
            Console.WriteLine("Consider the following prompt:");
            Console.WriteLine("--- Think of a time when you did something really difficult. ---");
            Console.WriteLine("When you have something in mind, press enter to continue.");
            _answer = Console.ReadLine();
            return _answer;
        }
        public string GetAnswer()
        {
            return _answer;
        }

        public void DisplayPrompt2()
        {
            Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        }  
        


    }
}