using System;
using System.Collections.Generic;


public class Menu
{
    public Menu()
    {

    }
    List<string> menuOpts = new List<string>
    {
        "1. Create a Goal",
        "2. List Goals",
        "3. Save Goals",
        "4. Load Goals",
        "5. Record Events",
        "6. Quit"
    };

    public void displayMenu()
    {
        foreach(string opts in menuOpts)
        {
            Console.WriteLine(opts);
        }
    }

}