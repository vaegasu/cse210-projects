using System;

class Listing : Activity
{
    public Listing()
    {

    }

    List<string> keepListing = new List<string>()
    {
        "> Who are you thankful for? ",
        "> What are your personal strengths? ",
        "> Who have you helped today? ",
        "> Who do you look up to the most? ",
        "> What are some tender mercies from the Lord you've noticed? ",
        "> How have your prayers been answered? ",
        "> What are the little things you've taken time to do that have added to your days? ",
        "> What does unconditional love look like to you? ",
        "> What would you tell your past self? ",
        "> How has Heavenly Father blessed your life this week? "
    };
    string _welcomeMessage = "This listing activity will help reflect on the good things in life.";

    public void startListing()
    {
        Timer listTime = new Timer();
        listTime.activityTime();
        int seconds = listTime._timeSet;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(listTime._timeSet);
        var prompt = new Random();
        int listIndex = prompt.Next(keepListing.Count);
        string listPrompt = keepListing[listIndex];
        Console.WriteLine(listPrompt);
        Console.WriteLine("Take a few seconds to think, then start listing. ");
        Thread.Sleep(5000);
        int lCount = 0;
        Console.WriteLine("List away! ");

       //if(startTime < endTime)
        {
            while(DateTime.Now < endTime)
            {
                Console.Write("> ");
                string list = Console.ReadLine();
                lCount++;            
            }
        }

        Console.WriteLine($"Great work! You have completed {seconds} seconds of the listing activity, and listed {lCount} things.");
        Thread.Sleep(5000);
        }


    }