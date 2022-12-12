using System;

namespace Practice4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a list of activity objects.
            List<Activity> activityList = new List<Activity>();

            //Create person's running activity.
            Running activity1 = new Running();
            var activity1Date = new DateOnly(2022, 12, 02);
            activity1.SetDate(activity1Date);
            activity1.SetMinutes(84);
            activity1.SetDistance(10);
            //Add it to the list!
            activityList.Add(activity1);

            //Create person's cycling activity.
            Cycling activity2 = new Cycling();
            var activity2Date = new DateOnly(2022, 12, 14);
            activity2.SetDate(activity2Date);
            activity2.SetMinutes(100);
            activity2.SetSpeed(30);
            activityList.Add(activity2);
            
            //Create person's swimming activity.
            Swimming activity3 = new Swimming();
            var activity3Date = new DateOnly(2022, 12, 21);
            activity3.SetDate(activity3Date);
            activity3.SetMinutes(60);
            activity3.SetLaps(7);
            activityList.Add(activity3);

            //Iterate through activities and print the summary.
            foreach (Activity a in activityList)
            {
                Console.WriteLine(a.GetSummary());
            }

        }
    }
}