using System;

namespace Foundation3
{
    public class Receptions : Event
    {

        protected string _email;

        public void SetEmail(string email)
        {
            _email = email;        
        }

        public string GetEmail()
        {
            return _email;
        }

    
        public void GetFullDetailsReception()
        {
            Console.WriteLine($"Event type: {_eventType}.");
            Console.WriteLine($"Title: {_eventTitle}.");
            Console.WriteLine($"Description: {_description}.");        
            Console.WriteLine($"Date: {_date} - Time: {_time}"); 
            Console.WriteLine($"RSVP by November 15th. {_email}.");                   
        }

    }

}