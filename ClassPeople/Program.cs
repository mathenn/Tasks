using System;
using ClassPeople;
using System.Globalization;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeesInfo();
        }

        static void PeopleInfo()
        {
            People people1 = new People();
            people1.Name = "Maria";
            people1.Age = 17;

            People people2 = new People();
            people2.Name = "João";
            people2.Age = 16;

            if (people1.Age > people2.Age)
            {
                Console.WriteLine("Older people: " + people1.Name);
            }
            else
            {
                Console.WriteLine("Older people: " + people2.Name);
            }
        }

        static void EmployeesInfo()
        {
            Employees employee1 = new Employees();

            employee1.Name = "Carlos Silva";
            employee1.Salary = 6300.00;

            Employees employee2 = new Employees();

            employee2.Name = "Ana Marques";
            employee2.Salary = 6700.00;

            double averageSalary = (employee1.Salary + employee2.Salary) / 2.0;

            Console.WriteLine($"The average salary of employees is = {averageSalary.ToString("F2", CultureInfo.InvariantCulture)}.");
        }
    }
}