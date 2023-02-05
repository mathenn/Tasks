using System;
using System.Globalization;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();

            Console.WriteLine("Enter product data:");

            Console.Write("Name:");
            product1.Name = Console.ReadLine();
            Console.Write("Price:");
            product1.Price = double.Parse(Console.ReadLine());
            Console.Write("Quantity in stock:");
            product1.Quantity = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Product data:" + product1);


        }
    }
}