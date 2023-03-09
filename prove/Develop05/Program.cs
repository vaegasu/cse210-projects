using System;
using System.Collections.Generic;

class Program
{        

    static void Main(string[] args)
    {
        bool startGoals = true;
        Console.WriteLine("\nWelcome to the Goals program. Please select from the following menu options: \n");

        while(startGoals == true)
        {
            Menu menu = new Menu();
            menu.displayMenu();
            Console.Write("\nEnter your selection: ");
            int choice = Int32.Parse(Console.ReadLine());

            if(choice == 1)
            {
                Goal goal = new Goal();
                Console.Write("\nName your goal: ");
                string name = Console.ReadLine();
                Console.Write("\nDescribe your goal: ");
                string description = Console.ReadLine();
                Console.Write("\nHow many points will this goal be worth? ");
                int points = Int32.Parse(Console.ReadLine());
                startGoals = true;
            }
            if(choice == 2)
            {
                Console.WriteLine("List Goals");
                startGoals = true;
            }
            if(choice == 3)
            {
                Console.WriteLine("Save Goals");
                startGoals = true;
            }
            if(choice == 4)
            {
                Console.WriteLine("Load Goals");
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
            else
            {
                Console.WriteLine("\nPlease make a valid selection from the list. \n");
                startGoals = true;
            }

        }

    }
}