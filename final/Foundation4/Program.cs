using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> activities = new List<string>();

        Activity activity1 = new Running("03 May 2023", 45, 3.25);
        string summary1 = activity1.getSummary();
        activities.Add(summary1);

        Activity activity2 = new Spinning("01 Apr 2023", 35, 6.50);
        string summary2 = activity2.getSummary();
        activities.Add(summary2);

        Activity activity3 = new Swimming("05 Apr 2023", 45, 8);
        string summary3 = activity3.getSummary();
        activities.Add(summary3);

        Activity activity4 = new Swimming("07 Apr 2023", 35, 6);
        string summary4 = activity4.getSummary();
        activities.Add(summary4);

        Activity activity5 = new Running("10 Apr 2023", 45, 2.50);
        string summary5 = activity5.getSummary();
        activities.Add(summary5);        

        Activity activity6 = new Spinning("13 Apr 2023", 50, 8.25);
        string summary6 = activity6.getSummary();
        activities.Add(summary6);

        for(int x = 0; x < activities.Count; x++)
        {
            Console.WriteLine(activities[x]);
        }
    }
}