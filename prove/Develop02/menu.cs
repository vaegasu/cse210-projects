using System;
using System.Collections.Generic;

public class Menu 
{
    public List<string> menuOpts = new List<string>()
    {
        "1. Write",
        "2. Display",
        "3. Load",
        "4. Save",
        "5. Quit"
    };
    public void DisplayMenuOpts() 
    {
        for(int x = 0; x < menuOpts.Count; x++)
        {
            Console.WriteLine(menuOpts[x]);
        }
    }
    };