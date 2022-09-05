using System.Collections.Generic;

namespace SIMS.Model
{
    public class Driver : User
    {
        public List<Tag> Tags { get; set; }

        public Driver(string name, string surname, string email, string password, string uniqueCitizensIdentityNumber, Role role, List<Tag> tags) : base(name, surname, email, password, uniqueCitizensIdentityNumber, role)
        {
            Tags = tags;
        }
    }
}