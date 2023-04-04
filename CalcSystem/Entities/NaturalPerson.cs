namespace CalcSystem.Entities
{
    class NaturalPerson : Person
    {
        public double HealthExpenditure { get; set; }

        public NaturalPerson(string name, double anualIncome, double healthExpenditure) : base(name, anualIncome)
        {
            HealthExpenditure = healthExpenditure;
        }

        public override double Tax()
        {
            double tax = 0;

            if (AnualIncome < 20000.00)
            {
                tax = (AnualIncome * 0.15);
            }
            else
            {
                tax = (AnualIncome * 0.25);
            }

            if (HealthExpenditure > 0)
            {
                HealthExpenditure -= HealthExpenditure * 0.5;
            }
            return tax - HealthExpenditure;
        }
    }
}
