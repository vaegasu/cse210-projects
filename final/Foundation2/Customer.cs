using System;

class Customer
{
    List<Address> addresses = new List<Address>();
    private string _custName;
    private int _custID;
    Address address = new Address();

    // private bool inUS;

    public Customer()
    {

    }
    public Customer(string name, int custID)
    {
        name = _custName;
        custID = _custID;
        
    }


}