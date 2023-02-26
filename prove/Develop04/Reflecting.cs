using System;

class Reflecting : Activity
{
    new string _welcomeMessage = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life. ";

    List<string> startQuestions = new List<string>()
    {
        "> Think of a time when you stood up for yourself or for someone. ",
        "> Think of a time when you did something really difficult. ",
        "> Think of a time when you helped someone in need. ",
        "> Think of a time when you did something truly selfless. ",
        "> Think of a time when you followed the promptings of the Holy Ghost. ",
        "> Think of something that happened recently that you want to remember. ",
        "> Think of a time you made someone smile. ",
        "> Think of a time when the work you were doing felt satisfying. "
    };

    List<string> refQuestions = new List<string>()
    {
        "> Why was this experience meaningful to you? ",
        "> Have you ever done anything like this before? ",
        "> How did you get started? ",
        "> How did you feel when it was complete? ",
        "> What made this time different than other times when you were not as successful? ",
        "> What is your favorite thing about this experience? ",
        "> What did you learn from this experience that applies to other situations? ",
        "> What did you learn about yourself from this experience? ",
        "> What do you look forward to because of this experience? ",
        "> Is there anything you would do differently because of this experience? ",
        "> What does this experience tell you about yourself? ",
        "> If you could tell your future self something about this experience, what would it be? ",
        "> How did this experience stretch your abilities? ",
        "> Has this experience changed your relationships with anyone? If so, how? ",
        "> What will you change because of this experience in your life? ",
        "> How has this experience given you confidence in yourself? "

    };
    public Reflecting()
    {

    }

    public void startReflecting()
    {
        Console.WriteLine(_welcomeMessage);
        Timer refTime = new Timer();
        refTime.activityTime();
        int seconds = refTime._timeSet;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(refTime._timeSet);
        if(DateTime.Now < endTime)
        {
            var random = new Random();
            int index = random.Next(startQuestions.Count);
            string startQ = startQuestions[index];
            Console.WriteLine(startQ);
            Thread.Sleep(10000);
            
            while(DateTime.Now < endTime)
            {
                var random2 = new Random();
                int index2 = random.Next(refQuestions.Count);
                string refQ = refQuestions[index2];
                refQuestions.Remove(refQuestions[index2]);
                Console.WriteLine(refQ);
                Thread.Sleep(10000);

            }
        }    

            Console.WriteLine($"Great work! You have completed {seconds} seconds of the reflecting activity. ");
            Thread.Sleep(5000);
        }
}