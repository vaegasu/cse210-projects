using System;

class Spinning : Activity
{
    protected double _speed;

    public Spinning()
    {

    }

    public Spinning(string date, int time, double speed)
    {
        _date = date;
        _minutes = time;
        _speed = speed;
        _activity = "Cycling";
    }

    public override double getSpeed()
    {
        return _speed;
    }

    public override double getPace()
    {
        double pace = Math.Round((60 / _speed), 2);
        return pace;
    }

        public override string getSummary()
    {
        string _summary = $"{_date}, {_activity} ({_minutes} mins), Speed: {getSpeed()} MPH, Pace: {getPace()} mins per mile.";
        return _summary;
    }
}