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

        while (start == true){
            Console.WriteLine("Welcome to Vae's Journal :D");
            Console.WriteLine("Please choose from the following:");
            Menu menu1 = new Menu();
            Console.WriteLine("What would you like to do today? ");
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
        Console.WriteLine("Thank you for stopping by. See you later. :D");
        start = false;
    }
    }

}

}

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