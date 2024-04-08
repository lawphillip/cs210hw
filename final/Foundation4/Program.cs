using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        activities.Add(new Cycling("April 3rd 2024", 30, 15));
        activities.Add(new Running("April 3rd 2024", 60, 5));
        activities.Add(new Swimming("April 3rd 2024", 60, 90));
        foreach(Activity activity in activities)
        {
            Console.WriteLine(activity.getsummary());
        }
    }
}
