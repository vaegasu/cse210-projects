using System;

class Breathing : Activity
{
    new string _welcomeMessage = "This activity is designed to focus on breathing in and out, relaxing your mind, and thinking only about your body and the breathing action. ";
    
    public Breathing()
    {

    }

    public void startBreathing()
    {
        Timer breatheTime = new Timer();
        breatheTime.activityTime();
        int seconds = breatheTime._timeSet;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(breatheTime._timeSet);
        if(startTime < endTime)
        {
            for(int x = 1; x < seconds;)
            {
                Console.Write("< < Breathe in . ");
                Thread.Sleep(1000);
                x++;
                Console.Write(" . ");
                Thread.Sleep(1000);
                x++;
                Console.Write(" . ");
                Thread.Sleep(1000);
                x++;
                Console.Write(" . ");
                Thread.Sleep(1000);
                x++;
                Console.Write(" . \n ");
                Thread.Sleep(1000);
                x++;

                Console.Write("> > > Breathe out.");
                Thread.Sleep(1000);
                x++;
                Console.Write(" . ");
                Thread.Sleep(1000);
                x++;
                Console.Write(" . ");
                Thread.Sleep(1000);
                x++;
                Console.Write(" . ");
                Thread.Sleep(1000);
                x++;
                Console.Write(" . ");
                Thread.Sleep(1000);
                x++;
                Console.Write(" . ");
                Thread.Sleep(1000);
                x++;
                Console.Write(" . ");
                Thread.Sleep(1000);
                x++;                                                                                                
            }
        
        Console.WriteLine($"Great work! You completed {seconds} seconds of the breathing activity. ");
        Thread.Sleep(5000);
        }

    }


}