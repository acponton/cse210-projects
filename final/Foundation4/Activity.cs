using System;

namespace Foundation4
{
    public class Activity
    {

        protected string _date;
        protected int _lengthMinutes;
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

        
    }

}