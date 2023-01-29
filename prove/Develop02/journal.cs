using System;
public class Journal
{
    public string journal_entries;
    public string write = "1. Write";
    public string display = "2. Display";
    public string load = "3. Load";
    public string save = "4. Save";
    public string quit = "5. Quit";

    public List<Entry> _entry = new List<Entry>();

    public void AddingEntry() 
    {
        Console.WriteLine(write);
    }

    public void DisplayJournal()
    {
        Console.WriteLine(display);

    }

    public void LoadFile()
    {
        Console.WriteLine(load);

    }

    public void SaveFile() 
    {
        Console.WriteLine(save);
    }

    public void Quit()
    {
        Console.WriteLine(quit);
    }

}

