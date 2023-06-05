using System;
using System.IO;
using System.Linq;
using Course.Entities;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file path: ");
            string path = Console.ReadLine();

            List<Employees> list = new List<Employees>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] employee = sr.ReadLine().Split(",");
                    string name = employee[0];
                    string email = employee[1];
                    double salary = double.Parse(employee[2], CultureInfo.InvariantCulture);
                    list.Add(new Employees(name, email, salary));
                }
            }

            Console.Write("Enter salary: ");
            double value = double.Parse(Console.ReadLine());
            var emails = list.Where(p => p.Salary > value).OrderBy(p => p.Name).Select(p => p.Email);
            Console.WriteLine("Email of people whose salary is more than " + value + ":");
            Console.WriteLine();

            foreach (string email in emails)
            {
                Console.WriteLine(email);
            }

            Console.WriteLine();

            var sum = list.Where(p => p.Name[0] == 'M').Select(p => p.Salary).Sum();
            Console.Write("Sum of salary of people whose name starts with 'M':" + sum);
            Console.WriteLine();
        }
    }
}