using System;
using System.Collections;

class Outdoor : Event
{
    protected string _weather;

    public string _eventType = "Outdoor Event";

    public Outdoor()
    {

    }
    public Outdoor(string forecast)
    {
        _weather = forecast;
    }

    public override string getStandard()
    {
        return $"   ---   ---   ---    \n{_title}\n{_description}\n{_date}, {_time}\nLocation: {_address}\n   ---   ---   ---   \n";
    }

    public override string getDetails()
    {
        return $" ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ \n{_title}\n{_description}\n When: {_date}, at {_time}\nLocation: {_address}\n This is An outdoor event! Please come dressed and prepared for {_weather}\n ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ \n";
    }

    public override string getShort()
    {
        return $"----------\n{_title}\nAn {_type} event\n{_date}\n----------\n";
    }
}