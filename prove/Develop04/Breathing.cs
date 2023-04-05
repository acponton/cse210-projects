using System;

namespace Develop04
{

    public class Breathing : Activity
    {

        protected int _activitySeconds;

        public Breathing()
        {

        }

        public void DisplayMessage()
        {
            Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
            Console.WriteLine("");
        }

        public void DisplayCountdown()
        {
            GetTime();

            _activitySeconds = GetTime();
            DateTime _startTime = DateTime.Now;
            DateTime _endTime = _startTime.AddSeconds(GetTime());

            if(_startTime < _endTime)
            {
                for(int x = 1; x < _activitySeconds;)
                {
                    Console.WriteLine();
                    Console.Write("Breathe in... 2 \n");
                    Thread.Sleep(1000);
                    x++;
                    Console.Clear();
                    Activity activity = new Activity();
                    activity.DisplayMessageReady();
                    Console.WriteLine("");
                    Console.Write("Breathe in... 1 \n");
                    Console.Write("1");
                    Thread.Sleep(1000);
                    x++;
                    Console.Clear();
                    activity.DisplayMessageReady();
                    Console.WriteLine("");
                    Console.Write("Breathe in... \n");
                    Console.Write("Now breathe out... 3 \n");
                    Thread.Sleep(1000);
                    x++;
                    Console.Clear();
                    activity.DisplayMessageReady();
                    Console.WriteLine("");
                    Console.Write("Breathe in... \n");
                    Console.Write("Now breathe out... 2 \n");
                    Thread.Sleep(1000);
                    x++;
                    Console.Clear();
                    activity.DisplayMessageReady();
                    Console.WriteLine("");
                    Console.Write("Breathe in... \n");
                    Console.Write("Now breathe out... 1 \n");
                    Thread.Sleep(1000);
                    x++;
                    
                    Console.Clear();
                    activity.DisplayMessageReady();
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.Write("Breathe in... \n");
                    Console.Write("Now breathe out... \n");
                    Console.WriteLine("");
                    Console.Write("Breathe in... 2 \n");
                    Thread.Sleep(1000);
                    x++;
                    Console.Clear();
                    activity.DisplayMessageReady();
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.Write("Breathe in... \n");
                    Console.Write("Now breathe out... \n");
                    Console.WriteLine("");
                    Console.Write("Breathe in... 1 \n");
                    Thread.Sleep(1000);
                    x++;
                    Console.Clear();
                    activity.DisplayMessageReady();
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.Write("Breathe in... \n");
                    Console.Write("Now breathe out... \n");
                    Console.WriteLine("");
                    Console.Write("Breathe in... \n");
                    Console.Write("Now breathe out... 3 \n");
                    Thread.Sleep(1000);
                    x++;
                    Console.Clear();
                    activity.DisplayMessageReady();
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.Write("Breathe in... \n");
                    Console.Write("Now breathe out... \n");
                    Console.WriteLine("");
                    Console.Write("Breathe in... \n");
                    Console.Write("Now breathe out... 2 \n");
                    Thread.Sleep(1000);
                    x++;
                    Console.Clear();
                    activity.DisplayMessageReady();
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.Write("Breathe in... \n");
                    Console.Write("Now breathe out... \n");
                    Console.WriteLine("");
                    Console.Write("Breathe in... \n");
                    Console.Write("Now breathe out... 1 \n");
                    Thread.Sleep(1000);
                    x++;
                    
                }                                                                                              
            }

        }
    }
}