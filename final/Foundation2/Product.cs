using System;

public class Product
{
    private string _productName;
    private string _productId;
    private double _price;
    private int _quantity;


    public Product()
    {

    }


    public Product(string productId, string productName, double price, int quantity)
    {
        _productId = productId;
        _productName = productName;   
        _price = price;
        _quantity = quantity;
    }

    public double GetPriceProduct()
    {
        return _price * _quantity;
    }

    public string GetProductName()
    {
        return _productName;
    }

    public string GetProductID()
    {
        return _productId;
    }
 
    Address address = new Address();
    public double TotalCost()
    {   
        double _totalPrice = GetPriceProduct();
        int _totalShipping = address.ShippingCost();
        double _totalCost = _totalPrice + _totalShipping;
        return _totalCost;
    }
}


