using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using SIMS.Model;

namespace SIMS.Repository
{
    public class DriversRepository : IDriversRepository
    {
        private List<Driver> _drivers;

        public DriversRepository() 
        {
            string json = File.ReadAllText(@"..\..\Data\Drivers.json");
            List<Driver> drivers = JsonConvert.DeserializeObject<List<Driver>>(json);
            _drivers = drivers;
        }
        
        public Driver GetDriver(User user)
        {
            foreach (Driver driver in _drivers)
            {
                if (driver.Email.Equals(user.Email))
                {
                    return driver;
                }
            }

            return null;
        }
        
        public Driver GetDriverByEmail(string email)
        {
            foreach (Driver driver in _drivers)
            {
                if (driver.Email.Equals(email))
                {
                    return driver;
                }
            }

            return null;
        }
        public void Update(Driver newDriver)
        {
            Driver driver = GetDriverByEmail(newDriver.Email);
            _drivers.Remove(driver);
            _drivers.Add(newDriver);
            
        }
        
        public void Save()
        {
            File.WriteAllText(@"..\..\Data\Drivers.json", JsonConvert.SerializeObject(_drivers));
        }
    }
}