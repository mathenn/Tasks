using Inheritance.Entities;
using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(100, "Matt", 0.0);
            BusinessAccount bacc = new BusinessAccount(150, "Alex", 0.0, 500.0);

            // UPCASTING
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1000, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1010, "Jef", 0.0, 500.0);

            // DOWNCASTING
            BusinessAccount acc4 = (BusinessAccount)acc2;

            if(acc3 is BusinessAccount)
            {
                BusinessAccount acc5 = (BusinessAccount)acc3;
                acc5.Loan(200.0);
                Console.WriteLine("Loan");
            } else
            {
                SavingsAccount acc5 = (SavingsAccount)acc3;
                acc5.UpdateBalance();
                Console.WriteLine("Update");
            }


        }
    }
}