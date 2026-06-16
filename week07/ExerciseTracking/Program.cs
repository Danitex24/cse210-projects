using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("03 Jun 2026", 30, 4.8));
        activities.Add(new Cycling("04 Jun 2026", 45, 20.0));
        activities.Add(new Swimming("05 Jun 2026", 40, 20));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}