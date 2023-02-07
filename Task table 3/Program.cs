﻿using System;
using System.Globalization;

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

            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 0: Rectangle(); break;
                case 1: EmployeeData(); break;
                case 2: StudentInfo(); break;
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
    }
}