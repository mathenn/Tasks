using System;
using System.Globalization;
using System.Threading;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();

            Console.WriteLine("Enter product data: ");


            Console.Write("Name: ");
            product1.Name = Console.ReadLine();

            Console.Write("Price: ");
            product1.Price = double.Parse(Console.ReadLine());

            Console.Write("Quantity: ");
            product1.Quantity = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("");

            Console.WriteLine("Product data:" + product1);
            Console.WriteLine("");
            Console.WriteLine("Exiting app...");
            Thread.Sleep(2000);
            Environment.Exit(0);
        }
    }
}