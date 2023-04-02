using System;

namespace Foundation4
{

    public class Cycling : Activity
    {
        protected double _speed;



        public void SetSpeed(double speed)
        {
            _speed = speed;
        }
        
        public override double GetSpeed()
        {
            // miles per hour
            return _speed;
        }

        public override double GetPace()
        {
            // min per mile
            return Math.Round((60 / _speed),2);
        }

        public string GetSummaryCycling()
        {
            return $"{_date} {_activityName} ({_lengthMinutes} min) - Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile.";
        }

    }
}