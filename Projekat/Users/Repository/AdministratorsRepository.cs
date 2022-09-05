using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using SIMS.Model;

namespace SIMS.Repository
{
    public class AdministratorsRepository : IAdministratorsRepository
    {
        private List<Administrator> _administrators;
        private const string FILENAME = @"..\..\Data\Administrators.json";

        public AdministratorsRepository()
        {
            string json = File.ReadAllText(FILENAME);
            List<Administrator> users = JsonConvert.DeserializeObject<List<Administrator>>(json);
            _administrators = users;
        }

        public Administrator GetAdministrator(User user)
        {
            foreach (Administrator administrator in _administrators)
            {
                if (administrator.Email.Equals(user.Email))
                {
                    return administrator;
                }
            }

            return null;
        }

        public Administrator GetAdministratorByEmail(string email)
        {
            foreach (Administrator administrator in _administrators)
            {
                if (administrator.Email.Equals(email))
                {
                    return administrator;
                }
            }

            return null;
        }
        public void Update(Administrator newAdministrator)
        {
            Administrator administrator = GetAdministratorByEmail(newAdministrator.Email);
            _administrators.Remove(administrator);
            _administrators.Add(newAdministrator);
            
        }
        
        public void Save()
        {
            File.WriteAllText(FILENAME, JsonConvert.SerializeObject(_administrators));
        }
    }
}