using System;

namespace Foundation4
{
    public class Activity
    {

        protected string _date;
        protected int _lengthMinutes;
        // protected int _distance;
        // protected int _speed;
        // protected int _pace;
        protected string _activityName;


        public void SetDate(string date)
        {
            _date = date;
        }

        public void SetLengthMinutes(int lengthMinutes)
        {
            _lengthMinutes = lengthMinutes;
        }

        public void SetActivityName(string activityName)
        {
            _activityName = activityName;
        }

        // public virtual double GetNumberLaps()
        // {
        //     return 0;
        // }
        public virtual double GetDistance()
        {
            return 0;
        }      

        public virtual double GetSpeed()
        {
            return 0;
        }

        public virtual double GetPace()
        {
            return 0;
        }

        // public abstract string GetSummary();

        // Running running = new Running();
        // Cycling cycling = new Cycling();
        // public virtual string GetSummary()
        // {
        //     return "";
        // }
        // {
        //     double distance = GetDistance();
        //     Console.WriteLine($"{_date} {_nameActivity} ({_lengthMinutes} min) - Distance {distance} miles, Speed {_speed} mph, Pace: {_pace} min per mile.");
        // }
        Swimming swimming = new Swimming();
        Running running = new Running();
        Cycling cycling = new Cycling();
        public void GetSummary()
        {
            // double distance = swimming.GetDistance();
            // double speed = running.GetSpeed();
            // double pace = cycling.GetPace();
            Console.WriteLine($"{_date} {_activityName} ({_lengthMinutes} min) - Distance {swimming.GetDistance()} miles, Speed {running.GetSpeed()} mph, Pace: {cycling.GetPace()} min per mile.");            
        }

        // public void ShowSummary()
        // {
        //     foreach (Activity activity in _activities)
        //     {
        //         activity.GetSummary();
        //     }
            
        // }
        // }

        
    }

}