using System;

namespace Foundation3
{
    public class Lectures : Event
    {
        protected string _speaker;
        protected int _capacity;

        public void SetLectures(string speaker, int capacity)
        {
            _speaker = speaker;
            _capacity = capacity;        
        }

        public string GetSpeaker()
        {
            return _speaker;
        }

        public int GetCapacity()
        {
            return _capacity;
        }

    
        public void GetFullDetailsLectures()
        {
            Console.WriteLine($"Event type: {_eventType}.");
            Console.WriteLine($"Title: {_eventTitle}.");
            Console.WriteLine($"Description: {_description}.");
            Console.WriteLine($"Speaker: {_speaker}.");
            Console.WriteLine($"Capacity: {_capacity} people.");
            Console.WriteLine($"Date: {_date} - Time: {_time}");                  
        }

    }
}