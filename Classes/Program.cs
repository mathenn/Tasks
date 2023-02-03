using Classes;
using System;
using System.Globalization;

namespace MyClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle x, y;

            x = new Triangle();
            y = new Triangle();

            Console.WriteLine("Enter the measures of triangle x:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Enter the measures of triangle y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double AreaX = x.Area();

            double AreaY = y.Area(); 

            Console.WriteLine("Área de x = " + AreaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de y = " + AreaY.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}