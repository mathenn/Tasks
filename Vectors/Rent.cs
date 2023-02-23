namespace MyVector
{
    internal class Rent
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Room { get; set; }


        public Rent (string name, string email, int room)
        {
            Name = name;
            Email = email;
            Room = room;
        }

        public override string ToString()
        {
            return Name + Email;
        }

    }
}
