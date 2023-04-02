using System;

class Swimming : Activity
{
    protected int _laps;
    protected double _distance;

    public Swimming()
    {

    }

    public Swimming(string date, int time, int laps)
    {
        _date = date;
        _minutes = time;
        _laps = laps;
        _activity = "Swimming";
    }

    public override double getLaps()
    {
        return _laps;
    }

    public override double getDistance()
    {
        _distance = Math.Round(((_laps * 50 )/( 1000 * 0.62)), 2);
        return _distance;
    }

    public override double getPace()
    {
        double pace = Math.Round((_minutes / _distance), 2);
        return pace;
    }

    public override double getSpeed()
    {
        double speed = Math.Round((60 / getPace()), 2);
        return speed;
    }
        public override string getSummary()
    {
        string _summary = $"{_date}, {_activity} ({_minutes} mins), Distance: {getDistance()} miles, Speed: {getSpeed()} MPH, Pace: {getPace()} mins per mile.";
        return _summary;
    }
}