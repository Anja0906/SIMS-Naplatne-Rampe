namespace SIMS.Model
{
    public class Administrator : User
    {
        public double Salary { get; set; }
        public Station Station { get; set; }

        public Administrator(string name, string surname, string email, string password, string uniqueCitizensIdentityNumber, Role role, double salary, Station station) : base(name, surname, email, password, uniqueCitizensIdentityNumber, role)
        {
            Salary = salary;
            Station = station;
        }
    }
}