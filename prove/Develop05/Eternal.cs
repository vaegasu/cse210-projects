using System;
using System.Collections.Generic;

class Eternal : Goal
{
    public Eternal()
    {

    }
    public string getName()
    {
        Console.WriteLine("\nWhat is the name of your goal? ");
        string name = Console.ReadLine();
        setName(name);
        return name;
    }
    public void setName(string name)
    {
        _name = name;
    }

    public string getDesc()
    {
        Console.WriteLine("\nWhat is a short description of your goal? ");
        string desc = Console.ReadLine();
        setDesc(desc);
        return desc;
    }

    public void setDesc(string desc)
    {
        _description = desc;
    }

    public int getPoints()
    {
        Console.WriteLine("\nHow many points is this goal worth? ");
        int points = Int32.Parse(Console.ReadLine());
        setPoints(points);
        return points;
    }

    public void setPoints(int points)
    {
        _pointVal = points;
    }
}