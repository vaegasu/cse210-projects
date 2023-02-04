using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
{
    bool start = true;

    while (start == true) {
    while (start == true){
        Menu menu1 = new Menu();
        Console.WriteLine("Welcome to Vae's Journal Program.");
        Console.WriteLine("Please choose from the following:")
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.WriteLine("What would you like to do? ");
        menu1.DisplayMenuOpts();
        string userChoice = Console.ReadLine();

    if (userChoice == "1") {
        JEntry NewEntry = new JEntry();
        string date = DateTime.UtcNow.ToString("MM/dd/yyyy"); 
        string prompt = displayPrompt();
        Console.WriteLine(prompt);
        string words = Console.ReadLine();
        string entry = (date + ", " + prompt + ", " + words);
        entries.Add(entry);

        Console.Write($"{prompt}\n>");
        string text = Console.ReadLine();
        Journal anEntry = new Journal(date, prompt, text);
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
        Console.Write(System.IO.File.ReadAllLines(filename));
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
        foreach(string entry in entries){
        System.IO.File.WriteAllText(filename, entry);
        foreach(string entry in entries)
        {
            System.IO.File.WriteAllText(filename, entry);
        };
    }
    else if (userChoice == "5") {
        start = false;
        Console.WriteLine("Thank you for stopping by, See you later. :D");
        start = false;
    }
    }

}