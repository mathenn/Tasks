using System.Globalization;

namespace Task_table_3
{
    internal class Employee
    {
        public string Name;
        public double GrossSalary;
        public double Tax;


        public double NetSalary()
        {
            return GrossSalary - Tax;
        }

        public void IncreaseSalary(double percentage)
        {
            GrossSalary = GrossSalary + (GrossSalary * percentage / 100.0);
        }

        public override string ToString()
        {
            return Name + ", $" + NetSalary().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
