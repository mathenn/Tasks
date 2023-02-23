using System;

namespace MyVector
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());

            Rent[] room = new Rent[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Rent: #" + (i + 1));
                Console.Write("Enter your name: ");
                string name = Console.ReadLine(); 

                Console.Write("Enter your email: ");
                string email = Console.ReadLine();

                Console.WriteLine("Choose your room (between 1 and 10): ");
                int rentroom = int.Parse(Console.ReadLine());

                room[rentroom] = new Rent(name, email);

                Console.WriteLine("Name: " );
                Console.WriteLine("Email: " );
                Console.WriteLine("Room: " );
            }

        }
    }
}