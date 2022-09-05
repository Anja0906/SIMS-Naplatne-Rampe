using System;
using System.Drawing;
using SIMS.Model;
using SIMS.Repository;

namespace SIMS.Controller
{
    public class ExitController : IExitController
    {
        private MainRepository _mainRepository;

        public ExitController(MainRepository mainRepository)
        {
            _mainRepository = mainRepository;
        }

        public void Add(Exit exit)
        {
            _mainRepository.ExitRepository.Add(exit);
        }
        
        public void Save()
        {
            _mainRepository.Save();
        }

        public bool IsSpeedExceeded(TimeSpan time, Exit exit)
        {
            int distance = CalculateKilometers(exit);
            double speed = Convert.ToDouble(distance)/time.Seconds;
            if (speed > 130)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int CalculateKilometers(Exit exit)
        {
            foreach (Section section in _mainRepository.PricelistRepository.Pricelist.Sections)
            {
                if (section.Entry.Equals(exit.StationOfEntry.Name) && section.Exit.Equals(exit.StationOfExit.Name))
                {
                    return section.Kilometers;
                }
            }

            return 0;
        }
    }
}