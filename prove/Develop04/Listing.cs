using System;

namespace Develop04
{

    public class Listing : Activity
    {

        protected string _name; 
        protected string _description; 
        // protected string _prompt; 
        protected string _answer; 


        public Listing()
        {

        }

        public void DisplayMessage()
        {
            Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
            Console.WriteLine("");
        }

        public void DisplayPrompt1()
        {
            Console.WriteLine("List as many responses you can to the following prompt: ");
            Console.WriteLine("--- When you have felt the Holy Ghost this month?  ---");
        }

        public string GetAnswer()
        {
            Console.WriteLine("");
            Console.WriteLine(">");
            _answer = Console.ReadLine();
            return _answer;
        }
        public void GetRandomPrompt()
        {

        }


        public void DisplayResponses()
        {

        }



    }


}