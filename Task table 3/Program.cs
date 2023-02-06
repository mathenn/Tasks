using System;
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

        }

        static void StudentInfo()
        {

        }
    }
}