using System;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        
        // FIRST CUSTOMER - NIGERIA
        Address address1 = new Address(
            "15 Allen Avenue",
            "Ikeja",
            "Lagos",
            "Nigeria"
        );

        Customer customer1 = new Customer("Godsown Daniels", address1);

        // PRODUCTS FOR FIRST ORDER
        Product product1 = new Product("Laptop", "P001", 500000, 1);
        Product product2 = new Product("Mouse", "P002", 5000, 2);
        Product product3 = new Product("Keyboard", "P003", 12000, 1);

        Order order1 = new Order(customer1);

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        // SECOND CUSTOMER - NIGERIA
        Address address2 = new Address(
            "25 Broad Street",
            "Victoria Island",
            "Lagos",
            "Nigeria"
        );

        Customer customer2 = new Customer("Precious Kenneth", address2);

        // PRODUCTS FOR SECOND ORDER
        Product product4 = new Product("Phone", "P004", 350000, 1);
        Product product5 = new Product("Headphones", "P005", 15000, 2);
        Product product6 = new Product("Charger", "P006", 8000, 1);

        Order order2 = new Order(customer2);

        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);

        // DISPLAY FIRST ORDER
        Console.WriteLine("========== ORDER 1 ==========");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: N{order1.GetTotalCost():N2}");
        Console.WriteLine();

        // DISPLAY SECOND ORDER
        Console.WriteLine("========== ORDER 2 ==========");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: N{order2.GetTotalCost():N2}");
    }
}