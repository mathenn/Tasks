using System.Globalization;

namespace Task_table_4
{
    internal class BankAccount
    {

        public int AccNumber { get; private set; }

        public string Name { get; set; }

        public double Balance { get; private set; }

        public BankAccount(int accNumber, string name)        /* Constructor */
        {
            AccNumber = accNumber;
            Name = name;
        }

        public BankAccount(int accNumber, string name, double balance): this(accNumber, name)
        {
            Balance = balance;
        }
            
    public void Deposit(double deposit)
        {
            if (deposit <= 0)
            {
                throw new ArgumentException("Deposit amount can't be 0.");
            }
            else
            {
                Balance += deposit;
                Console.WriteLine("Deposit succeed!");
            }
        }

        public void Withdraw(double balance)
        {
            Balance -= balance + 5.00;
        }

        public override string ToString()
        {
            return "Conta: "
            + AccNumber
            + ", Owner: "
            + Name
            + ", Balance: $"
            + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }
   
    }
}

