using System;

namespace SIMS.Model
{
    [Serializable]
    public  class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UniqueCitizensIdentityNumber { get; set; }
        public Role Role { get; set; }

        public User(string name, string surname, string email, string password, string uniqueCitizensIdentityNumber, Role role)
        {
            Name = name;
            Surname = surname;
            Email = email;
            Password = password;
            UniqueCitizensIdentityNumber = uniqueCitizensIdentityNumber;
            Role = role;
        }
        
        
    }
}