using System;

class Activity
{
    protected string _date;
    protected int _minutes;
    protected string _summary;
    protected string _activity;

    public Activity()
    {

    }

    public Activity(string date, int time)
    {
        _date = date;
        _minutes = time;
    }

    public virtual double getLaps()
    {
        return 0.00;
    }
    public virtual double getDistance()
    {
        return 0.00;
    }
    public virtual double getSpeed()
    {
        return 0.00;
    }
    
    public virtual double getPace()
    {
        return 0.00;
    }
    public virtual string getSummary()
    {
        return "";
    }

}