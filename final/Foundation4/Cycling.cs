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

        // public Cycling(string date, int lengthMinutes, double speed)
        // {
        //     _speed = speed;
        // }
        
        public override double GetSpeed()
        {
            // miles per hour
            return _speed;
        }

        public override double GetPace()
        {
            // min per mile
            return 60 / _speed;
        }

        // public override string GetSummary()
        // {
        //     return $"{_date} Cycling ({_lengthMinutes} min) - Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile.";
        // }

    }

}