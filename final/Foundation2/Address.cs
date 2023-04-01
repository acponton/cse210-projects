using System;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address()
    {

    }

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public string DisplayFullAddress()
    {
        return $"{_street}, {_city}, {_state}, {_country}";
    }                                                                                                                                                                                                                                                                                                                                                   

    public int ShippingCost()
    {
        if (_country == "USA")
        {
            int _shippingCost = 5;
            return _shippingCost;
        }
        else
        {
            int _shippingCost = 35;       
            return _shippingCost;                                                                                                                                                                                                        
        }
    }

}