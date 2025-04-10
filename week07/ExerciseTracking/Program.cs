using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create different activities
        var running = new Running(new DateTime(2025, 06, 4), 30, 3.0); 
        var cycling = new Cycling(new DateTime(2025, 06, 4), 45, 12.0); 
        var swimming = new Swimming(new DateTime(2025, 06, 4), 30, 20); 
      

        // Put them in a list
        List<Activity> activities = new List<Activity> { running, cycling, swimming, };

        // Display summaries
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}