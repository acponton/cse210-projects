using System;

namespace Foundation4
{

    public class Swimming : Activity
    {

        protected double _numberLaps;
        // protected double _distance;


        public void SetNumberLaps(double numberLaps) 
        {
            _numberLaps = numberLaps;
        }

        
        public double GetNumberLaps()
        {
            return _numberLaps;
        }

        public override double GetDistance()
        {
            // miles per hour
            return _numberLaps * 50 / 1000 * 0.62;
            // return _distance;
        } 

        public override double GetSpeed()
        {
            // miles per hour
            return 60 / GetPace();
        }

        public override double GetPace()
        {
            // min per mile
            return _lengthMinutes / GetDistance();
        }

        // public override string GetSummary()
        // {
        //     return $"{_date} Swimming ({_lengthMinutes} min) - Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile.";
        // }
    }

}