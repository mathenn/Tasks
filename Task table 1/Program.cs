using Microsoft.Win32;
using System;
using System.Globalization;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Welcome to my console app :)");
            Console.WriteLine("");

            Console.WriteLine("PS: This program is just a combination of some simple exercises I did, if you are a beginner feel free to play them :)");
            Console.WriteLine("");
            Console.WriteLine("would you like to test the functionality of some exercise? Feel free!");
            Console.WriteLine("");

            Console.WriteLine("Choose what type of exercise you would like to perform:");
            Console.WriteLine("");

            Console.WriteLine("0 - Find interval.");
            Console.WriteLine("1 - Condition.");
            Console.WriteLine("2 - Validation.");
            Console.WriteLine("3 - Multiple.");
            Console.WriteLine("4 - Play time.");
            Console.WriteLine("5 - Value to pay.");
            Console.WriteLine("6 - Products (There is no interaction, this exercise just reproduces on the console what the exercise asked for.).");

            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 0: FindInterval(); break;
                case 1: Condition(); break;
                case 2: Validation(); break;
                case 3: Multiple(); break;
                case 4: PlayTime(); break;
                case 5: ValueToPay(); break;
                case 6: Products(); break;
                default: Menu(); break;
            }
        }

        static void FindInterval()
        {
            double number = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (number < 0 || number > 100)
            {
                Console.WriteLine("Out of range");
            }
            else if (number <= 25.0)
            {
                Console.WriteLine("Range of [0, 25.00].");
            }
            else if (number <= 50.0)
            {
                Console.WriteLine("Range of [25.01, 50.00].");
            }
            else if (number <= 75.0)
            {
                Console.WriteLine("Range of [50.01, 75.00]");
            }
            else
            {
                Console.WriteLine("Range of [75.01, 100.00].");
            }
        }

        static void Condition()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Enter a integer number:");
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0)
            {
                Console.WriteLine("Pair!");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Odd!");
                Console.WriteLine("");
            }
        }

        static void Validation()
        {
            Console.WriteLine("Enter a number to validation:");
            int x = int.Parse(Console.ReadLine());

            if (x < 0)
            {
                Console.WriteLine("Negative!");
            } else
            {
                Console.WriteLine("Positive!");
            }
        }

        static void Multiple()
        {
            Console.WriteLine("");
            Console.WriteLine("Enter two numbers to verify if they are multiple:");

            string[] values = Console.ReadLine().Split(' ');
            int A = int.Parse(values[0]);
            int B = int.Parse(values[1]);

            if (A % B == 0 || B % A == 0)
            {
                Console.WriteLine("Are multiple!");
            }
            else
            {
                Console.WriteLine("Aren't multiple!");
            }
        }

        static void PlayTime()
        {
            Console.WriteLine("");
            Console.WriteLine("enter the time you started and the time you finished playing:");

            string[] values = Console.ReadLine().Split(' ');
            int initialTime = int.Parse(values[0]);
            int finalTime = int.Parse(values[1]);

            int duration;
            if (initialTime < finalTime)
            {
                duration = finalTime - initialTime;
            } else
            {
                duration = 24 - initialTime + finalTime;
            }
        }

        static void ValueToPay()
        {
            string[] values = Console.ReadLine().Split(' ');
            int code = int.Parse(values[0]);
            int quantity = int.Parse(values[1]);

            double total;
            if (code == 1)
            {
                total = quantity * 4.0;
            } else if (code == 2)
            {
                total = quantity * 4.50;
            } else if (code == 3)
            {
                total = quantity * 5.0;
            } else if (code == 4)
            {
                total = quantity * 2.0;
            } else
            {
                total = quantity * 1.5;
            }
        }

        static void Products()
        {
            string product1 = "Computer";
            string product2 = "Office table";

            byte age = 30;
            int code = 5290;
            char gender = 'M';

            double price1 = 2100.0;
            double price2 = 650.50;
            double measure = 53.234567;

            Console.WriteLine("Products: ");
            Console.WriteLine("");

            Console.WriteLine($"{product1}, whose price is ${price1}.");
            Console.WriteLine($"{product2}, whose price is ${price2}.");
            Console.WriteLine("");

            Console.WriteLine($"Register: {age} years old, code: {code} and gender: {gender}.");
            Console.WriteLine("");

            Console.WriteLine($"Measure to eight decimal places: {measure:F8}");
            Console.WriteLine($"Rounded (to three decimal places): {measure:F3}");
            Console.WriteLine($"Culture invariant decimal separator: {measure:F3}");
            Console.WriteLine("");
        }
    }

}