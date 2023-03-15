using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goalsList = new List<Goal>();
        int points = 0;
        bool startGoals = true;
        Console.WriteLine($"You have earned {points} points.");
        Console.WriteLine("Welcome to the Eternal Goals program. Please select from the following menu options: ");

        while(startGoals == true)
        {
            Menu menu = new Menu();
            menu.displayMenu();
            Console.Write("Enter your selection: ");
            int choice = Int32.Parse(Console.ReadLine());

            if(choice == 1)
            {
                Menu menu1 = new Menu();
                Console.WriteLine("What type of goal would you like to create? ");
                menu.displayGoalTypes();
                Console.Write("Enter your selection: ");
                int type = Int32.Parse(Console.ReadLine());

                if(type == 1)
                {
                    Simple goal1 = new Simple();
                    string name = goal1.promptName();
                    string desc = goal1.promptDesc();
                    int pointVal = goal1.promptPoints();
                    goalsList.Add(goal1);
                }
                if(type == 2)
                {
                    Checklist goal2 = new Checklist();
                    string name = goal2.promptName();
                    string desc = goal2.promptDesc();
                    int pointVal = goal2.promptPoints();
                    int numEntries = goal2.promptEntries();
                    int numTillDone = numEntries;
                    goalsList.Add(goal2);                  
                }
                if(type == 3)
                {
                    Eternal goal3 = new Eternal();
                    string name = goal3.promptName();
                    string desc = goal3.promptDesc();
                    int pointVal = goal3.promptPoints();
                    goalsList.Add(goal3);                  
                }
                Console.WriteLine("Make another selection: ");
                startGoals = true;
            }

            if(choice == 2)
            {
                int x = 1;
                foreach(Goal Goal in goalsList)
                {
                    Goal glist = new Goal();
                    string name = Goal._name;
                    string type = Goal._type;
                    string desc = Goal._description;
                    int pworth = Goal._pointVal;
                    int numEntries = Goal._numEntries;
                    int numTillDone = Goal._numTillDone;
                    
                    if(Goal._type == "S")
                    {
                        Console.WriteLine($"{x++}. [ ] {name}, {desc}, worth {pworth} points.");
                    }
                    else if(Goal._type == "C")
                    {
                        Console.WriteLine($"{x++}. [ ] {name}, {desc}, worth {pworth} points, {numEntries} / {numTillDone} completed.");
                    }
                    else if(Goal._type == "E")
                    {
                        Console.WriteLine($"{x++}. [ ] {name}, {desc}, worth {pworth} points. *Eternal*");
                    }
                }
                startGoals = true;
            }

            if(choice == 3)
            {
                Console.WriteLine("What filename should this save to? ");
                string fileName = (Console.ReadLine());
                int i = 1;
                    using (StreamWriter outputFile = new StreamWriter(fileName))
                    {
                        foreach (Goal goal in goalsList)
                        {
                            if(goal._type == "S")
                            {
                                outputFile.WriteLine($"{i++}. |[ ] | {goal._name}, | {goal._description}, | worth {goal._pointVal} points | {goal._type}");
                            }
                            else if(goal._type == "C")
                            {
                                outputFile.WriteLine($"{i++}. |[ ] | {goal._name}, | {goal._description}, | worth {goal._pointVal} points | {goal._type} | {goal._numEntries} / {goal._numTillDone} completed.");
                            }
                            else if(goal._type == "E")
                            {
                                outputFile.WriteLine($"{i++}. |[ ] | {goal._name}, | {goal._description}, | worth {goal._pointVal} points | {goal._type}");
                            } 
                            else 
                            {
                                Console.WriteLine("Error");
                                break;
                            }
                        }
                    }

                startGoals = true;
            }

            if(choice == 4)
            {
                Goal goal = new Goal();
                Console.WriteLine("Enter the filename to be opened: ");
                string filename = (Console.ReadLine());
                    string[] lines = System.IO.File.ReadAllLines(filename);
                    foreach(string line in lines)
                    {
                        string[] parts = line.Split("|");
                        goal._name = parts[0];
                        goal._description = parts [1];
                        goal._pointVal = Int32.Parse(parts [2]);
                        goal._isComplete = bool.Parse(parts [3]);
                        goal._type = parts[4];
                        goal._numEntries = Int32.Parse(parts[5]);
                        goal._numTillDone = Int32.Parse(parts[6]);
                    }
                    goalsList.Add(goal);

            }

            if(choice == 5)
            {
                Console.WriteLine("Which goal are you recording?");
                int goalNum = Int32.Parse(Console.ReadLine());

                startGoals = true;
            }

            if(choice == 6)
            {
                Console.WriteLine("Well done for working on your goals!");
                startGoals = false;
                //Console.Clear;
            }
        }
    }
}