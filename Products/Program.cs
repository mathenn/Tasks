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

            Console.Write("Enter quantity to add to stock:");
            int qnt = int.Parse(Console.ReadLine());
            product1.AddProduct(qnt);
            Console.WriteLine("");

            Console.WriteLine("Updated data:" + product1);
            Console.WriteLine("");

            Console.Write("Enter the number of products to be removed:");
            int removeqnt = int.Parse(Console.ReadLine());
            product1.RemoveProduct(removeqnt);

            Console.WriteLine("Updated data:" + product1);
            Console.WriteLine("");

            Console.WriteLine("Exiting app...");
            Thread.Sleep(2000);
            Environment.Exit(0);
        }
    }
}