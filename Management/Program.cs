using System.Globalization;
using Management.Entities;

namespace Management
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int products = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; i <= products; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported  (c/u/i)? ");
                char resp = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                if (resp == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, customsFee));
                }
                else if (resp == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateOnly manufacture = DateOnly.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new UsedProduct(name, price, manufacture));
                } 
                else
                {
                    list.Add(new Product(name, price));
                }

            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");
            foreach (Product item in list)
            {
                Console.WriteLine(item.PriceTag());
            }
        }
    }
}