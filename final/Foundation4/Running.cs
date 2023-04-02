using System;

class Running : Activity
{
    protected double _distance;

    public Running(string date, int time, double dist)
    {
        _date = date;
        _minutes = time;
        _distance = dist;
        _activity = "Running";

    }

    public Running()
    {

    }
    public override double getDistance()
    {
        return _distance;
    }

    public override double getPace()
    {
        double pace = Math.Round((_minutes / _distance), 2);
        return pace; 
    }

    public override double getSpeed()
    {
        double speed = Math.Round(((_distance / _minutes) * 60), 2);
        return speed;
    }

    public override string getSummary()
    {
        string _summary = $"{_date}, {_activity} ({_minutes} mins), Distance: {_distance}, Speed: {getSpeed()} MPH, Pace: {getPace()} mins per mile.";
        return _summary;
    }
}