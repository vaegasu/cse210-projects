using System;
using System.Collections;

class Customer
{
    private string _custName;
    private Address _address;
    private string _addy;

    public Customer(string name, Address _address)
    {
        _custName = name;
        _addy = $"{_address._addString}";

    }
    

    public string getName()
    {
        return $"{_custName}";
    }
    public string getAddy()
   {
        return $"{_addy}";
    }
}