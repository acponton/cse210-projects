using System;

namespace Foundation4
{
    
    class Program
    {
        static void Main(string[] args)
        {
            List<Activity> _activities = new List<Activity>();

            Cycling cycling1 = new Cycling();
            cycling1.SetActivityName("Cycling");
            cycling1.SetDate("10 feb 2023");
            cycling1.SetLengthMinutes(30);
            cycling1.SetSpeed(5.5);
            cycling1.GetSummary();
            _activities.Add(cycling1);

            Running running1 = new Running();
            running1.SetActivityName("Running");
            running1.SetDate("03 apr 2023");
            running1.SetLengthMinutes(30);
            running1.SetDistance(3.0);
            running1.GetSummary();
            _activities.Add(running1);

            Swimming swimming1 = new Swimming();
            swimming1.SetActivityName("Swimming");
            swimming1.SetDate("15 jan 2023");
            swimming1.SetLengthMinutes(45);
            swimming1.SetNumberLaps(10.5);
            swimming1.GetSummary();
            _activities.Add(swimming1);

            

            // for(int index = 0; index < _activities.Count; index++)
            // {
            //     Console.WriteLine(_activities[index]);
            // }

        

        }
    }
}
