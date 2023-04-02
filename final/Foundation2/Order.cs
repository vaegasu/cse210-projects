using System;
using System.Collections;


class Order
{
    public List<Product> _products = new List<Product>();
    public Customer _customer;
    public string _address;

    public Order(Customer customer)
    {
        _customer = customer; 
        _address = _customer.getAddy();

    }
    public void shipLabel(Customer _customer)
    {
        
        Console.WriteLine($">>>Shipping Label: {_customer.getName()} {_customer.getAddy()}");
        Console.WriteLine("--------------------");
    
    }

    public void packLabel(List<Product> _products, Customer _customer)
    {
        Console.WriteLine($">>>Packing Label for: {_customer.getName()}");

        for(int x = 0; x < _products.Count; x++)
        {
            string name = _products[x].getProd();
            Console.WriteLine($"{name}");

        }
        Console.WriteLine("--------------------");
    }

    public void totalBill(List<Product> _products, Customer _customer, Address _address)
    {
        Console.WriteLine($">>>Receipt for: {_customer.getName()}");
        double total = 0;
        double ship = _address.inUS();
        total += ship;
        for(int x = 0; x < _products.Count; x++)
        {
            total += _products[x].totalCost();
            string name = _products[x].getProd();
            Console.WriteLine($"{name}, ${_products[x].totalCost()}");

        }
        Console.WriteLine($"Shipping: ${ship}");
        Console.WriteLine($"Total: ${total}");
        Console.WriteLine("--------------------");

    }
}