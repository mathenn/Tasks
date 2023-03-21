using System;
using ClientOrders.Entities;
using System.Globalization;

namespace ClientOrders
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date(DD/MM/YYYY: ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(name, email, date);
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order?");
            int qntItems = int.Parse(Console.ReadLine());

            for(int i = 1; i <= qntItems; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.WriteLine("Product name: ");
                string productName = Console.ReadLine();
                Console.WriteLine("Product price: ");
                double productPrice = double.Parse(Console.ReadLine());

                Product product = new Product(productName, productPrice);

                Console.WriteLine("Quantity:");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantity, productPrice, product);
                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);

        }
    }
}