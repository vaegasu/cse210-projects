using System;
using System.Collections;


class Product
{
    private int _prodID;
    private string _prodName;
    private double _price;
    private int _quantity;

    public Product()
    {

    }
    public Product(int ID, int quant)
    {
        _prodID = ID;
        _quantity = quant;
    }

    public Product(int ID, string prod, double cost, int quant)
    {
        _prodID = ID;
        _prodName = prod;
        _price = cost;
        _quantity = quant;

    }
    public string getProd()
    {
        return $"-- Product ID: {_prodID}, item: {_prodName}, quantity: {_quantity} ";
    }
    public double totalCost()
    {
        double total = _quantity * _price;
        return total;
    }
}