using CalcSystem.Entities;
using System.Globalization;

namespace CalcSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();

            Console.Write("Enter the number of tax payers: ");
            double n = double.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char res = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double income = double.Parse(Console.ReadLine());
                if (res == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenses = double.Parse(Console.ReadLine());
                    list.Add(new NaturalPerson(name, income, healthExpenses));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    list.Add(new LegalPerson(name, income, employees));
                }
            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");
            foreach (Person person in list)
            {
                Console.WriteLine(person.Name + ": $" + person.Tax().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}