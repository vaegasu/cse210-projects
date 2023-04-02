using System;
using System.Collections;

class Reception : Event
{
    protected string _emailRSVP;

    public string _eventType = "Reception";

    public Reception()
    {

    }

    public Reception(string email)
    {
        _emailRSVP = email;
    }
        public override string getStandard()
    {
        return $"\n          *****          \n{_title}\n{_description}\n {_date}, at {_time}\n{_address}\n          *****          \n";
    }

    public override string getDetails()
    {
        return $"\n  **  **  **  **  **  **  **  **  \nWe are pleased to announce the {_title}\n{_description}\n Please Join Us to Celebrate:\n{_date}, from {_time}\n We will be celebrating at {_address}\n\n >>>  Please RSVP at {_emailRSVP} <<< \n  **  **  **  **  **  **  **  **  \n ";
    }

    public override string getShort()
    {
        return $"\n*** Save the Date *** \n{_title}\n{_date}\n   ***      ***      ***   \n";
    }
}