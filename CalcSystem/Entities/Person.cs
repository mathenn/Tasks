namespace CalcSystem.Entities
{
    abstract class Person
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }
        public List<Person> Persons { get; set; } = new List<Person>();

        public Person(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Tax();
        
    }
}
