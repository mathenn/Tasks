using System;
using System.Globalization;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
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
    }
}