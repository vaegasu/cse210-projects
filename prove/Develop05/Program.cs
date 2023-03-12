using System;
using System.Collections.Generic;

class Program
{        


    static void Main(string[] args)
    {
        List<Goal> goalsList = new List<Goal>();
        int x = 0;
        int points = 0;
        bool startGoals = true;
        Console.WriteLine($"\nYou have earned {points} points.");
        Console.WriteLine("\nWelcome to the Eternal Goals program. Please select from the following menu options: \n");

        while(startGoals == true)
        {
            Menu menu = new Menu();
            menu.displayMenu();
            Console.Write("\nEnter your selection: ");
            int choice = Int32.Parse(Console.ReadLine());

            if(choice == 1)
            {
                Menu menu1 = new Menu();
                Console.WriteLine("\nWhat type of goal would you like to create? ");
                menu.displayGoalTypes();
                Console.Write("\nEnter your selection: ");
                int type = Int32.Parse(Console.ReadLine());

                if(type == 1)
                {
                    x += 1;
                    Simple goal1 = new Simple();
                    string name = goal1.getName();
                    string desc = goal1.getDesc();
                    int pointVal = goal1.getPoints();
                    // string goal11 = goal1.ToString();
                    goalsList.Add(goal1);
                    // startGoals = true; 

                }
                if(type == 2)
                {
                    x += 1;
                    Checklist goal2 = new Checklist();
                    string name = goal2.getName();
                    string desc = goal2.getDesc();
                    int pointVal = goal2.getPoints();
                    int numEntries = goal2.getEntries();
                    goalsList.Add(goal2);
                    // startGoals = true;                    
                }
                if(type == 3)
                {
                    x += 1;
                    Eternal goal3 = new Eternal();
                    string name = goal3.getName();
                    string desc = goal3.getDesc();
                    int pointVal = goal3.getPoints();
                    goalsList.Add(goal3);
                    // startGoals = true;                    
                }
                // else
                // {
                //     Console.WriteLine("Please make a valid selection.");
                // }
                Console.WriteLine("\nMake another selection: ");
                startGoals = true;
            }

            if(choice == 2)
            {
                foreach(Goal Goal in goalsList)
                {
                    Goal glist = new Goal();
                    string name = Goal._name;
                    string desc = Goal._description;
                    int pworth = Goal._pointVal;
                    Console.WriteLine($"{x}. [ ] {name}, {desc}, worth {pworth} points.");
                }
                startGoals = true;
            }

            if(choice == 3)
            {
                
                Console.WriteLine("\nWhat filename should this save to? ");
                startGoals = true;
            }

            if(choice == 4)
            {
                Console.WriteLine("Enter the filename to be opened: ");
                string filename = (Console.ReadLine());
                string lines = System.IO.File.ReadAllLines(filename);
                startGoals = true;
            }

            if(choice == 5)
            {
                Console.WriteLine("Record Events");
                startGoals = true;
            }

            if(choice == 6)
            {
                Console.WriteLine("Well done for working on your goals!");
                startGoals = false;
            }
            // else
            // {
            //     Console.WriteLine("\nPlease make a valid selection from the list. \n");
            //     startGoals = true;
            // }

        }
    }
}