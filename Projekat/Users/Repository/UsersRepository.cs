using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using SIMS.Model;

namespace SIMS.Repository
{
    public class UsersRepository : IUsersRepository
    {
        private List<User> _users;

        public UsersRepository()
        {
            string json = File.ReadAllText(@"..\..\Data\Users.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(json);
            _users = users;
        }

        public User GetUserByEmail(string email)
        {
            foreach (User user in _users)
            {
                if (user.Email.Equals(email))
                {
                    return user;
                }
            }

            return null;
        }

        public void Update(User newUser)
        {
            User user = GetUserByEmail(newUser.Email);
            _users.Remove(user);
            _users.Add(newUser);
            
        }
        
        public void Save()
        {
            File.WriteAllText(@"..\..\Data\Users.json", JsonConvert.SerializeObject(_users));
        }
    }
}