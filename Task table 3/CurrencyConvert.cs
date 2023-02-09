namespace Task_table_3
{
    internal class CurrencyConvert
    {
        public double DollarQuotation;
        public double BuyDollars;

        public double CurrencyConverter()
        {
            double iofTax = (DollarQuotation * BuyDollars) / 100 * 6;
            double reaisToPay = (DollarQuotation * BuyDollars) + iofTax;
            return reaisToPay;
        }
    }
}
