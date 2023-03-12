using System;
using System.Collections.Generic;

class Goal
{
    // int x = 0;
    public string _name;
    public string _description;
    public int _pointVal;
    public int _numEntries;
    bool _isComplete;
    string _checkBox;
    string _checkedOff;
    // https://www.c-sharpcorner.com/UploadFile/mahesh/create-a-list-of-objects-in-C-Sharp/

    public Goal()
    {

    }

    public Goal(string name, string description, int pointVal, bool isComplete)
    {
        _name = name;
        _description = description;
        _pointVal = pointVal;
        _isComplete = false;

    }


    // public string getName()
    // {
    //     Console.WriteLine("\nWhat is the name of your goal? ");
    //     string name = Console.ReadLine();
    //     setName(name);
    //     return name;
    // }
    //     public void setName(string name)
    // {
    //     _name = name;
    // }

    // public string getDesc()
    // {
    //     Console.WriteLine("\nWhat is a short description of your goal? ");
    //     string description = Console.ReadLine();
    //     setDesc(description);
    //     return description;
    // }
    // public void setDesc(string description)
    // {
    //     _description = description;
    // }

    // public int getPoints()
    // {
    //     Console.WriteLine("\nHow many points will this goal be worth?");
    //     int points = Int32.Parse(Console.ReadLine());
    //     setPoints(points);
    //     return points;
    // }

    // public void setPoints(int points)
    // {
    //     _pointVal = points;
    // }

}