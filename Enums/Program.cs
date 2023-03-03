using System;
using Course.Entities;
using Course.Entities.Enums;

namespace MyEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment,
            };

            Console.WriteLine(order);


            // Enum to string //
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            // String to enum //
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);
        }
    }
}