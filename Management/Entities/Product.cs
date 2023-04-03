using System.Globalization;

namespace Management.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();

        public Product()
        {

        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            return Name 
            + " $" 
            + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
