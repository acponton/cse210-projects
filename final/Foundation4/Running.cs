using System;

namespace Foundation4
{

    public class Running : Activity
    {

        protected double _distance;


        public void SetDistance(double distance)
        {
            _distance = distance;
        }

        // public void SetDistance(double distance)
        // {
        //     _distance = distance;
        // }

        // public override double GetDistance()
        // {
        //     // miles per hour
        //     return _numberLaps * 50 / 1000 * 0.62;
        // } 

        public override double GetDistance()
        {
            // miles per hour
            return _distance;
        } 

        public override double GetSpeed()
        {
            // miles per hour
            return (_distance / _lengthMinutes) * 60;
        }

        public override double GetPace()
        {
            // min per mile
            return _lengthMinutes / _distance;
        }

        // public override string GetSummary()
        // {
        //     return $"{_date} Running ({_lengthMinutes} min) - Distance {_distance} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile.";
        // }
    }

}