using System;
using SIMS.Model;
using SIMS.Repository;

namespace SIMS.Controller
{
    public class DriversController : IDriversController
    {
        private DriversRepository _driversRepository;
        private MainRepository _mainRepository;

        public DriversController(MainRepository mainRepository)
        {
            _driversRepository = mainRepository.DriversRepository;
            _mainRepository = mainRepository;
        }

        public void BuyTag(Driver driver, Tag tag)
        {
            Random random = new Random();
            tag.Id = random.Next(0000, 9999).ToString();
            driver.Tags.Add(tag);
        }
        
        public void Save()
        {
            _mainRepository.Save();
        }
    }
}