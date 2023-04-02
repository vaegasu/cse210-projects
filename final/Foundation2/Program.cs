using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>();

        Product product1 = new Product(1, "50 foot tarpaulin", 50.00, 1);
        products.Add(product1);
        Product product2 = new Product(2, "5 man outdoor tent", 100.00, 1);
        products.Add(product2);
        Product product3 = new Product(3, "Camping stove", 45.00, 1);
        products.Add(product3);
        Product product4 = new Product(4, "Backpack", 35.00, 1);
        products.Add(product4);
        Product product5 = new Product(5, "Hiking boots", 75.00, 2);
        products.Add(product5);
        Product product6 = new Product(6, "Waterproof rain jacket", 40.00, 1);
        products.Add(product6);
        Product product7 = new Product(7, "Dehydrated meals", 20.00, 10);
        products.Add(product7);
        Product product8 = new Product(8, "Fire starting kit", 10.00, 1);
        products.Add(product8);
        Product product9 = new Product(9, "Camping cook pot", 15.00, 1);
        products.Add(product9);
        Product product10 = new Product(10, "Water filter", 15.00, 1);
        products.Add(product10);
        Product product11 = new Product(11, "50 foot rope", 25.00, 1);
        products.Add(product11);

        Address address1 = new Address("1234 Main Street", "Santa Clarita", "CA", "Vietnam");
        Customer customer1 = new Customer("Jane Doe", address1);

        Address address2 = new Address("5678 State Street", "Salt Lake City", "UT", "US");
        Customer customer2 = new Customer("Jill Jones", address2);

        Address address3 = new Address("9876 Block Street", "Sheboygan", "MI", "USA");
        Customer customer3 = new Customer("Cody Mavencort", address3);

        Address address4 = new Address("5432 Corner Lane", "Okanogan", "WA", "US");
        Customer customer4 = new Customer("Chili Palmer", address4);

        Order order1 = new Order(customer1);
        order1._products.Add(product10);
        order1._products.Add(product7);
        order1._products.Add(product8);
        order1.packLabel(order1._products, customer1);
        order1.shipLabel(customer1);
        order1.totalBill(order1._products, customer1, address1);
        Console.Write("Press enter to see the next order.");
        Console.ReadLine();
        Console.Clear();

        Order order2 = new Order(customer2);
        order2._products.Add(product1);
        order2._products.Add(product5);
        order2._products.Add(product4);
        order2._products.Add(product2);
        order2.packLabel(order2._products, customer2);
        order2.shipLabel(customer2);
        order2.totalBill(order2._products, customer2, address2);
        Console.Write("Press enter to see the next order.");
        Console.ReadLine();
        Console.Clear();

        Order order3 = new Order(customer3);
        order3._products.Add(product3);
        order3._products.Add(product6);
        order3._products.Add(product9);
        order3._products.Add(product7);
        order3.packLabel(order3._products, customer3);
        order3.shipLabel(customer3);
        order3.totalBill(order3._products, customer3, address3);
        Console.Write("Press enter to see the next order.");
        Console.ReadLine();
        Console.Clear();

        Order order4 = new Order(customer4);
        order4._products.Add(product1);
        order4._products.Add(product2);
        order4._products.Add(product3);
        order4._products.Add(product4);
        order4._products.Add(product5);
        order4._products.Add(product6);
        order4._products.Add(product7);
        order4._products.Add(product8);
        order4._products.Add(product9);
        order4._products.Add(product10);
        order4.packLabel(order4._products, customer4);
        order4.shipLabel(customer4);
        order4.totalBill(order4._products, customer4, address4);
        Console.Write("Press enter to see the next order.");
        Console.ReadLine();
        Console.Clear();        
    }
}