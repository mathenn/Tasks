using System;
using System.Globalization;
using Task_table_4;

namespace MyTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc1;

            Console.Write("Enter the account number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.Write("Enter the name of the account owner: ");
            Console.Write("");
            string name = Console.ReadLine();

            Console.WriteLine("");
            Console.Write("There will be initial deposit? Type 'Y' for yes or 'N' for no. ");
            Console.WriteLine("");

            char res = char.Parse(Console.ReadLine().ToUpper());
            if (res == 'Y')
            {
                Console.Write("What is the amount of the initial deposit? ");
                double balance = double.Parse(Console.ReadLine());
                acc1 = new BankAccount(number, name, balance);
                Console.WriteLine("");
            } else
            {
                acc1 = new BankAccount(number, name);
            }

            Console.WriteLine("Updating your data...");
            Console.WriteLine("");
            Console.WriteLine("Account info:");
            Console.WriteLine(acc1);

            Console.WriteLine("Withdrawing...");
            acc1.Withdraw(100);
            Console.WriteLine(acc1);
            Console.WriteLine("");

            Console.WriteLine("Depositing...");
            acc1.Deposit(150);
            Console.WriteLine(acc1);
            Console.WriteLine("");
        }
    }
}