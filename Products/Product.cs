using System.Globalization;

namespace Tasks
{
    internal class Product
    {
        public string Name;
        public double Price;
        public int Quantity;

        public double TotalInStock()
        {
            return Price * Quantity;
        }

        public void AddProduct(int quantity)
        {
            Quantity += quantity;
        }

        public void RemoveProduct(int quantity)
        {
            Quantity -= quantity;
        }

        public override string ToString()
        {
            return Name
            + ", $"
            + Price.ToString("F2", CultureInfo.InvariantCulture)
            +", "
            + Quantity.ToString("F2", CultureInfo.InvariantCulture)
            +" units, total: $"
            + TotalInStock().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
