using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Task_table_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("Select the function you want to run: ");
            Console.WriteLine("0 - Rectangle area, perimeter and diagonal");
            Console.WriteLine("1 - Employee data");
            Console.WriteLine("2 - Student information");
            Console.WriteLine("3 - Currency converter");

            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 0: Rectangle(); break;
                case 1: EmployeeData(); break;
                case 2: StudentInfo(); break;
                case 3: ExchangeCurrency(); break;
                default: Menu(); break;
            }
        }

        static void Rectangle()
        {
            Rectangle rectangle = new Rectangle();

            Console.WriteLine("Enter the width value:");
            rectangle.Width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Enter the height value:");
            rectangle.Height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Area = " + rectangle.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimeter = " + rectangle.Perimeter().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + rectangle.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }

        static void EmployeeData()
        {
            Employee emp1 = new Employee();

            Console.WriteLine("Enter your name:");
            emp1.Name = Console.ReadLine();
            Console.WriteLine("");
            
            Console.WriteLine("Enter your salary:");
            emp1.GrossSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("");

            Console.WriteLine("Tax to pay:");
            emp1.Tax = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("");

            Console.WriteLine($"Employee: {emp1}");
            Console.WriteLine("");

            Console.WriteLine("Type a percentage to increase salary:");
            double percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            emp1.IncreaseSalary(percent);
            Console.WriteLine("");

            Console.WriteLine($"Updated employee data: {emp1}");

        }

        static void StudentInfo()
        {
            Student student1 = new Student();

            Console.WriteLine("Student name:");
            student1.Name = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Enter the 3 grades of the student:");
            student1.Grade1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            student1.Grade2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            student1.Grade3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("");

            Console.WriteLine("FINAL GRADE: " + student1.FinalGrade().ToString("F2", CultureInfo.InvariantCulture));
            if (student1.Approved())
            {
                Console.WriteLine("Approved!");
            } else
            {
                Console.WriteLine("Disapproved!");
                Console.WriteLine($"Missing {student1.PointsLeft().ToString("F2", CultureInfo.InvariantCulture)} points.");
            }
        }

        static void ExchangeCurrency()
        {
            CurrencyConvert currencyDollar = new CurrencyConvert();

            Console.WriteLine("What is the dollar exchange rate?");
            Console.WriteLine("");
            currencyDollar.DollarQuotation = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("");

            Console.WriteLine("How many dollars are you going to buy?");
            Console.WriteLine("");
            currencyDollar.BuyDollars = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("");

            Console.WriteLine("amount to be paid in reais: $" + currencyDollar.CurrencyConverter().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("");
            Console.WriteLine("Would you like to do another currency conversion? Type 'Y' for yes or 'N' for no.");
            Console.WriteLine("");

            char res = char.Parse(Console.ReadLine().ToUpper());
            Console.WriteLine("");

            if (res == 'Y')
            {
                ExchangeCurrency();
            } else
            {
                Console.WriteLine("Would you like to return to menu? Type 'Y' for return or 'N' for exit the application.");
                Console.WriteLine("");

                char response = char.Parse(Console.ReadLine().ToUpper());
                if (response == 'Y')
                {
                    Console.WriteLine("");
                    Console.WriteLine("Going back to the menu...");
                    Thread.Sleep(2000);
                    Menu();
                } else
                {
                    ExitApp();
                }
            }

        }
        
        static void ExitApp()
        {
            Console.WriteLine("");
            Console.WriteLine("Exiting the application... :(");
            Thread.Sleep(2200);
            Environment.Exit(0);
        }
    }
}