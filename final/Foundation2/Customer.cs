using System;

public class Customer
{
    private string _name;
    private string _customerId;

    
    public string GetNameCustomer()
    {
        return _name;
    }

    Address address = new Address();

    public string GetFullAddress()
    {
        string _fullAddress = address.DisplayFullAddress();
        return _fullAddress;
    }

    public Customer()
    {

    }

    public Customer(string name, string customerId)
    {
        _name = name;
        _customerId = customerId;
    }


    public string GetName()
    {
        return _name;
    }

}