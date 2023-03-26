using System;

class Product
{
    public int _prodID;
    public string _prodName;
    private double _price;
    public int _quantity;

    public Product()
    {

    }

    public Product(int ID, string prod, double cost, int quant)
    {
        ID = _prodID;
        prod = _prodName;
        cost = _price;
        quant = _quantity;

    }

    public double totalCost(int quantity, float price)
    {
        double total = quantity * price;
        return total;
    }
}