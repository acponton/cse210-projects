using System;

namespace Foundation4
{

    public class Swimming : Activity
    {

        protected double _numberLaps;


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
            return Math.Round((_numberLaps * 50 / 1000 * 0.62), 2);
        } 

        public override double GetSpeed()
        {
            // miles per hour
            return Math.Round((60 / GetPace()), 2);
        }

        public override double GetPace()
        {
            // min per mile
            return Math.Round((_lengthMinutes / GetDistance()), 2);
        }

        public string GetSummarySwimming()
        {
            return $"{_date} {_activityName} ({_lengthMinutes} min) - Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile.";
        }
    }

}