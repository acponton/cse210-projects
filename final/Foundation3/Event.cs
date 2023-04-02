using System;

namespace Foundation3
{
    public class Event
    {

        protected string _eventTitle;
        protected string _eventType;
        protected string _description;
        protected string _date;
        protected string _time;


        public void SetEvent(string eventTitle, string eventType, string description, string date, string time)
        {
            _eventTitle = eventTitle;
            _eventType = eventType;
            _description = description;
            _date = date;
            _time = time;
        }

        public void GetStandardDetails()
        {
            Console.WriteLine($"Title: {_eventTitle}.");
            Console.WriteLine($"Description: {_description}.");
            Console.WriteLine($"Date: {_date} - Time: {_time}");
        }

        public void GetShortDescription()
        {
            Console.WriteLine($"Event Type: {_eventType}.");
            Console.WriteLine($"Title: {_eventTitle}.");
            Console.WriteLine($"Date: {_date}");
        }

    }
}