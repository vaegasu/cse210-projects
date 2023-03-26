using System;

class Order
{
    List<Product> products = new List<Product>();
 
    private int _orderNumber;
    private float ship;

    public Order()
    {

    }


    public string shipLabel(string custName, string address)
    {
        string shipLabel = $"{custName}\n{address}";
        return shipLabel;

    }
    public string packLabel(int orderNum)
    {
        orderNum = _orderNumber;
        string prodLabel = "";

        foreach(Product product in products)
        {
            string name = product._prodName;
            int number = product._prodID;
            int quantity = product._quantity;
            prodLabel = $"Item: {name} ({number}), Quantity: {quantity}";
        }

        string packLabel = $"{orderNum}\n{prodLabel}";
        return packLabel;

    }
    
}