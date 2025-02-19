using System;
using System.Collections.Generic;

class Product
{
    private string _productName;
    private string _serialNumber;
    private DateTime _purchaseDate;
    private double _cost;

    public Product(string productName, string serialNumber, DateTime purchaseDate, double cost)
    {
        _productName = productName;
        _serialNumber = serialNumber;
        _purchaseDate = purchaseDate;
        _cost = cost;
    }

    public override string ToString()
    {
        return String.Format("{0,-15}{1,-15}{2,-15}{3,-15}", _productName, _serialNumber, _purchaseDate.ToString("dd-MM-yyyy"), _cost);
    }
}

class Program
{
    static void Main()
    {
        List<Product> productList = new List<Product>();

        Console.WriteLine("Enter number of products:");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter product details (Name, Serial Number, Purchase Date (dd-MM-yyyy), Cost) separated by comma:");
            string[] input = Console.ReadLine().Split(',');
            string name = input[0].Trim();
            string serial = input[1].Trim();
            DateTime date = DateTime.ParseExact(input[2].Trim(), "dd-MM-yyyy", null);
            double cost = double.Parse(input[3].Trim());

            productList.Add(new Product(name, serial, date, cost));
        }

        Console.WriteLine(String.Format("{0,-15}{1,-15}{2,-15}{3,-15}", "Product Name", "Serial Number", "Purchase Date", "Purchase Cost"));
        
        foreach (var product in productList)
        {
            Console.WriteLine(product);
        }
    }
}