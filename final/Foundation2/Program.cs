using System;

class Program
{
    static void Main(string[] args)
    {

        List<Order> orders = new List<Order>();

        Order order1 = new Order();
        Customer cust1 = new Customer("Sarah", 70700);
        Address add1 = new Address("1234 Black St.", "Sheboygan","Michigan","12345","USA");
        Product prod1 = new Product(10234, "Black Boots size 9", 45.00, 1);
        Product prod2 = new Product(12345, "5 foot rope", 20.00, 5);
        Product prod3 = new Product(23456, "10 foot tarpaulin", 100.00, 2);

    }
}