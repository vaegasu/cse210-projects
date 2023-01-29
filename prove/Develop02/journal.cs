using System;
public class Journal
{
    public string _entries;

    public List<Entry> _entry = new List<Entry>();

    public void AddingEntry() 
    {
        Console.WriteLine("1. Write");
    }

    public void DisplayJournal()
    {
        Console.WriteLine("2. Display");

    }

    public void LoadFile()
    {
        Console.WriteLine("3. Load");

    }

    public void SaveFile() 
    {
        Console.WriteLine("4. Save");
    }

    public void Quit()
    {
        Console.WriteLine("5. Quit");
    }

}

