using System;
using System.Collections;

class Lecture : Event
{
    protected string _speaker;
    
    public string _eventType = "Lecture";
    protected int _capacity;
    protected string _lectureSummary;

    public Lecture()
    {

    }
    public Lecture(string speaker, int seats)
    {
        string type = _type;
        string date = _date;
        string time = _time;
        string addy = _address;
        _speaker = speaker;
        string desc = _description;
        _capacity = seats;
        _lectureSummary = $"{_speaker}, {desc}, {date} {time}, at {addy}. {_capacity} Seats are available.";
        
    }
    public override string getStandard()
    {
        
        return $"--------------------\n{_title}\nFeaturing guest speaker {_speaker}\n{_date}, {_time}\n{_address}\n--------------------\n";
    }
    public override string getShort()
    {
        return $"----------\n{_type} by {_speaker}\n{_title}\n{_date}\n----------\n";
    }
    public override string getDetails()
    {
        return $"     *****     \n--- {_title} ---\nA special Lecture by {_speaker}\nWhen: {_date}, at {_time}\nWhere: {_address}\n >>> Seating is limited to {_capacity}, so reserve your seat soon <<< \n     *****     \n ";
    }
}