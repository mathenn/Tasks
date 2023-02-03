using System;
using System.Globalization;

namespace MyCMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("Hello, here i have two exercises, do you wanna try one?");
            Console.WriteLine("");

            Console.WriteLine("If yes, type the respective number in order to access the method:");
            Console.WriteLine("");

            Console.WriteLine("0 - Check if password is correct (PS: 2002 is the password).");
            Console.WriteLine("");
            Console.WriteLine("1 - Coordinates of x and y.");
            Console.WriteLine("");
            Console.WriteLine("2 - Preference of customers (of a gas station).");
            Console.WriteLine("");

            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 0: CheckPassword(); break;
                case 1: Coordinates(); break;
                case 2: PreferenceOfCustomers(); break;
                default: Menu(); break;
            }
        }

         static void CheckPassword()
        {
            Console.WriteLine("Type your password: ");
            Console.WriteLine("");
            int pass = int.Parse(Console.ReadLine());

            while (pass != 2002)
            {
                Console.WriteLine("Wrong password, try again.");
                pass = int.Parse(Console.ReadLine());
                if (pass == 2002)
                {
                    Console.WriteLine("Correct password! Access allowed.");
                }
            }
        }

         static void Coordinates()
        {
            Console.WriteLine("Type the coordenates 'x' and 'y':");
            Console.WriteLine("");
            string[] values = Console.ReadLine().Split(' ');
            int x = int.Parse(values[0]);
            int y = int.Parse(values[1]);

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("First.");
                } else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Second.");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Third.");
                } else
                {
                    Console.WriteLine("Fourth.");
                }
                values = Console.ReadLine().Split(' ');
                x = int.Parse(values[0]);
                y = int.Parse(values[1]);
            }
        }

        static void PreferenceOfCustomers()
        {
            int alcohol = 0;
            int gasoline = 0;
            int diesel = 0;

            Console.WriteLine("What type of fuel would you like to add? (Type a number).");
            Console.WriteLine("");
            Console.WriteLine("1 - Alcohol");
            Console.WriteLine("2 - Gasoline");
            Console.WriteLine("3 - Diesel");
            Console.WriteLine("4 - Quit");
            int type = int.Parse(Console.ReadLine());

            while (type != 4)
            {
                if (type == 1)
                {
                    alcohol = alcohol + 1;
                } else if (type == 2)
                {
                    gasoline = gasoline + 1;
                } else if (type == 3)
                {
                    diesel = diesel + 1;
                }

                if (type < 1 || type > 4)
                {
                    Console.WriteLine("The number doesn't exist as an option, please try again.");
                }


                type = int.Parse(Console.ReadLine());
            }

            {
            Console.WriteLine("Thank you so much!");
            Console.WriteLine("Alcohol: " + alcohol);
            Console.WriteLine("Gasoline: " + gasoline);
            Console.WriteLine("Diesel: " + diesel);
            }

        }
    }
}