using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using SIMS.Model;

namespace SIMS.Repository
{
    public class ManagersRepository : IManagersRepository
    {
        private List<Manager> _managers;

        public ManagersRepository()
        {
            string json = File.ReadAllText(@"..\..\Data\Managers.json");
            List<Manager> managers = JsonConvert.DeserializeObject<List<Manager>>(json);
            _managers = managers;
        }
        
        public Manager GetManager(User user)
        {
            foreach (Manager manager in _managers)
            {
                if (manager.Email.Equals(user.Email))
                {
                    return manager;
                }
            }

            return null;
        }
        
        public Manager GetManagerByEmail(string email)
        {
            foreach (Manager manager in _managers)
            {
                if (manager.Email.Equals(email))
                {
                    return manager;
                }
            }

            return null;
        }
        public void Update(Manager newManager)
        {
            Manager manager = GetManagerByEmail(newManager.Email);
            _managers.Remove(manager);
            _managers.Add(newManager);
            
        }
        
        public void Save()
        {
            File.WriteAllText(@"..\..\Data\Managers.json", JsonConvert.SerializeObject(_managers));
        }
    }
}