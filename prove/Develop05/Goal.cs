using System;
using System.Collections.Generic;

class Goal
{
    protected string _name;
    protected string _description;
    protected int _pointVal;
    protected bool _isComplete;
    protected string _checkBox = "[ ]";
    protected string _checkedOff = "[X]";
    // https://www.c-sharpcorner.com/UploadFile/mahesh/create-a-list-of-objects-in-C-Sharp/
    public List<Goal> goals = new List<Goal>();

    public Goal()
    {

    }

    public virtual CreateGoal()
    {

    }


}