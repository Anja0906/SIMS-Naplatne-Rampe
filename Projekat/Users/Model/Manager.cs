namespace SIMS.Model
{
    public class Manager : User
    {
        public double Salary { get; set; }

        public Manager(string name, string surname, string email, string password, string uniqueCitizensIdentityNumber, Role role, double salary) : base(name, surname, email, password, uniqueCitizensIdentityNumber, role)
        {
            Salary = salary;
        }
    }
}