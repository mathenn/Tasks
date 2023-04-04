namespace CalcSystem.Entities
{
    class LegalPerson : Person
    {
        public int EmployeesNumber { get; set; }

        public LegalPerson(string name, double anualIncome, int employeesNumber) : base(name, anualIncome)
        {
            EmployeesNumber = employeesNumber;
        }

        public override double Tax()
        {
            double tax = 0;

            if (EmployeesNumber > 10)
            {
                tax = (AnualIncome * 0.14);
            }
            else
            {
                tax = (AnualIncome * 0.16);
            }

            return tax;
        }

    }
}
