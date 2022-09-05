namespace SIMS.Model
{
    public class Worker : User
    {
        
        public Shift Shift { get; set; }
        public double Salary { get; set; }
        public Station Station { get; set; }
        public Place Place { get; set; }

        public Worker(string name, string surname, string email, string password, string uniqueCitizensIdentityNumber, Role role, Shift shift, double salary, Station station, Place place) : base(name, surname, email, password, uniqueCitizensIdentityNumber, role)
        {
            Shift = shift;
            Salary = salary;
            Station = station;
            Place = place;
        }

        public override string ToString()
        {
            return this.Name + " " + this.Email + " " + this.Station.Name;
        }
    }
}