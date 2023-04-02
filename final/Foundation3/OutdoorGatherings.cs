using System;

namespace Foundation3
{
    public class OutdoorGatherings : Event
    {

        protected string _weather;

        public void SetWeather(string weather)
        {
            _weather = weather;       
        }

        public void GetFullDetailsLectures()
        {
            Console.WriteLine($"Event type: {_eventType}.");
            Console.WriteLine($"Title: {_eventTitle}.");
            Console.WriteLine($"Description: {_description}.");
            Console.WriteLine($"Weather: {_weather}.");
            Console.WriteLine($"Date: {_date} - Time: {_time}");                    
        }


    }
}