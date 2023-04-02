using System;

namespace Foundation4
{
    public class Activity
    {

        protected string _date;
        protected double _lengthMinutes;
        // protected int _distance;
        // protected int _speed;
        protected int _pace;
        protected string _nameActivity;
        public List<Activity> _activities = new List<Activity>();


        public void SetActivity(string nameActivity, string date, double lengthMinutes)
        {
            _nameActivity = nameActivity;
            _date = date;
            _lengthMinutes = lengthMinutes;
        }
        public abstract double GetDistance();      

        public abstract double GetSpeed();

        public abstract double GetPace();


        public void GetSummary()
        {
            Console.WriteLine($"{_date} {_nameActivity} ({_lengthMinutes} min) - Distance {_distance} miles, Speed {_speed} mph, Pace: {_pace} min per mile.");
        }

        public void ShowSummary()
        {
            foreach (Activity activity in _activities)
        {
            activity.GetSummary();
        }
        }

        
    }

}