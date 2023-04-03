using System.Globalization;

namespace Management.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {

        }

        public ImportedProduct(string name, double price, double customsFee) :base (name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            Price = Price + CustomsFee;
            return Price;
        }

        public override string PriceTag()
        {
            return Name 
            + " $"
            + TotalPrice().ToString("F2", CultureInfo.InvariantCulture)
            + " (Customs fee: $" 
            + CustomsFee.ToString("F2", CultureInfo.InvariantCulture) 
            + ")";
        }


    }
}
