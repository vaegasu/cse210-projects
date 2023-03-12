using System;
using System.Collections.Generic;

class Goal
{
    public string _name;
    public string _description;
    public int _pointVal;
    public int _numEntries;
    bool _isComplete;
    string _checkBox;
    string _checkedOff;
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

}