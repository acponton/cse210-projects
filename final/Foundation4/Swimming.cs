using System;

namespace Foundation4
{

    public class Swimming : Activity
    {

        protected double _numberLaps;


        public void SetLaps(double numberLaps)
        {
            _numberLaps = numberLaps;
        }

        public override double GetDistance()
        {
            // miles per hour
            return _numberLaps * 50 / 1000 * 0.62;
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
    }

}