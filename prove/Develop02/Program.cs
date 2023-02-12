using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        bool start = true;
        List<string> entries = new List<string>()
    {   
    };

    Console.WriteLine("~~ Welcome to Vae's Journal :D ~~");

    while (start == true){
        Menu menu1 = new Menu();
        Console.WriteLine("Please choose from the following:");
        menu1.DisplayMenuOpts();
        string userChoice = Console.ReadLine();

    if (userChoice == "1") {
        string date = DateTime.UtcNow.ToString("MM/dd/yyyy"); 
        string prompt = displayPrompt();
        Console.Write($"{prompt}\n>");
        string text = Console.ReadLine();
        string anEntry = ($"{date}, {prompt}, {text}");
        Journal entry1 = new Journal(date, prompt, text);
        entries.Add($"{date}, {prompt}, {text}");
    }

    else if (userChoice == "2") {
        foreach(string entry in entries){

            Console.WriteLine(entry);
        }
    }

    else if (userChoice == "3"){
        Console.Write("Enter a filename to load from, .txt: ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach(string line in lines)
        {
            string[] parts = line.Split(",");
            string date = parts[0];
            string prompt = parts[1];
            string text = parts[2];
            Console.WriteLine($"Date: {date}, Prompt: {prompt} Entry: {text}");
        }
    }

    else if (userChoice == "4"){
        Console.Write("Enter a filename to save to, .txt: ");
        string filename = Console.ReadLine();
        foreach(string entry in entries)
        {
            System.IO.File.WriteAllText(filename, entry);
        };
    }
    else if (userChoice == "5") {
        Console.WriteLine("Thank you for stopping by. Hope to see you later! :D ~~");
        start = false;
    }
    }
}

 static List<string> prompt = new List<string>()
        {
            "How did Heavenly Father blessed you today? :D",
            "What are two things you accomplished today? :D",
            "Share a favorite scripture of yours and explain why it's your favorite. :D",
            "Share a time someone went out of there way for you. :D",
            "What's on your mind today? And why? :D",
            "What is something you can do to bless someone today? :D",
            "What's something you would tell your past self? :D",
            "Write a letter to someone in Heaven :D",
            "Write a letter to someone you haven't seen a while :D",
            "Write a motivation note to your favorite person :D",
            "What are you thankful for today? :D",
            "How was your day? What was the highlight of your day? Anything new? :D",

        };

    static string displayPrompt()
        {
            var random = new Random();
            int index = random.Next(prompt.Count);
            string randomPrompt = prompt[index];
            return randomPrompt;

        }

}