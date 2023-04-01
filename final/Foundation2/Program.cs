using System;

class Program
{
    static void Main(string[] args)
    {

        Order order1 = new Order();
        Address address = new Address();
        Customer customer1 = new Customer("Andrea Ponton", "0002532");
        Address address1 = new Address("9900 w 58th st", "Countryside", "IL", "USA");

        Customer customer2 = new Customer("Marcos Pepper", "0002536");
        Address address2 = new Address("La Rioja Etapa Asturias", "Daule", "Guayas", "ECU");

        Product product1 = new Product("0015", "Liahona Magazine", 2.50, 150);
        Product product2 = new Product("0046", "CTR Rings", 1.50, 350);
        Product product3 = new Product("0028", "Temple Art", 5.25, 250);

        order1._products.Add(product1);
        order1._products.Add(product2);
        order1._products.Add(product3);

        Console.WriteLine("");
        Console.WriteLine("********** Packing Label **********");
        Console.WriteLine("");
        Console.WriteLine($"Product: {product1.GetProductName()} - Id#: {product1.GetProductID()} - Subtotal: $ {product1.GetPriceProduct()} - Shipping Cost: $ {address1.ShippingCost()} - Total Cost: $ {product1.GetPriceProduct()+address1.ShippingCost()}");
        Console.WriteLine($"Product: {product2.GetProductName()} - Id#: {product2.GetProductID()} - Subtotal: $ {product2.GetPriceProduct()} - Shipping Cost: $ {address2.ShippingCost()} - Total Cost: $ {product2.GetPriceProduct()+address2.ShippingCost()}");
        Console.WriteLine($"Product: {product3.GetProductName()} - Id#: {product3.GetProductID()} - Subtotal: $ {product3.GetPriceProduct()} - Shipping Cost: $ {address1.ShippingCost()} - Total Cost: $ {product3.GetPriceProduct()+address1.ShippingCost()}");
        Console.WriteLine("");


     
        Console.WriteLine("");
        Console.WriteLine("********** Shipping Label **********");
        Console.WriteLine("");
        Console.WriteLine($"{customer1.GetName()} - {address1.DisplayFullAddress()}");
        Console.WriteLine($"{customer2.GetName()} - {address2.DisplayFullAddress()}");
        Console.WriteLine("");

    }

}