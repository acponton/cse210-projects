using System;


public class Order
{
    public List<Product> _products = new List<Product>();
    public List<Customer> _customers = new List<Customer>();


    public Order()
    {

    }

    
    Product product = new Product();
    public string PackingLabel()
    {
        return $"{product.GetProductID} - {product.GetProductName}";
    }

   
    public void GetPackingLabel()
    {
        foreach (Product product in _products)
        {
            Console.WriteLine(PackingLabel());
        }
    }

    Customer customer = new Customer();
    public void GetShippingLabel()
    {
        string _nameCustomer = customer.GetNameCustomer();
        string _address = customer.GetFullAddress();

        foreach (Customer customer in _customers)
        {
            Console.WriteLine($"{_nameCustomer} - {_address}");
        }
    }

}