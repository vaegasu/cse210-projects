
public class Prompt; 
{
    static List<string> prompt = new List<string>()
        {
            "How did Heavenly Father blessed you today? (:",
            "What are two things you accomplished today? (:",
            "Share a favorite scripture of yours and explain why it's your favorite. (:",
            "Share a time someone went out of there way for you. (:",
            "What's on your mind today? And why? (:",
            "What is something you can do to bless someone today? (:",
            "What's something you would tell your past self? (:",
            "Write a letter to someone in Heaven (:",
            "Write a letter to someone you haven't seen a while",
            "How was your day? What was the highlight of your day? Anything new?",

        };

    static string displayPrompt()
    {
        var random = new Random();
        int index = random.Next(prompt.Count);
        string randomPrompt = prompt[index];
        return randomPrompt;

    }

}
