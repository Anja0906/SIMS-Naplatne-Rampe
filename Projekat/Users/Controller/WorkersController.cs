using System;
using SIMS.Model;
using SIMS.Repository;

namespace SIMS.Controller
{
    public class WorkersController : IWorkersController
    {
        private WorkersRepository _workersRepository;
        private MainRepository _mainRepository;

        public WorkersController(MainRepository mainRepository)
        {
            _workersRepository = mainRepository.WorkersRepository;
            _mainRepository = mainRepository;
        }
        
        public void InitQueue()
        {
            _mainRepository.EntryRepository.Enqueue(new Entry(DateTime.Today, _mainRepository.StationsRepository.GetStationByName("Pojate"), "BG1234", VehicleType.Car));
            _mainRepository.EntryRepository.Enqueue(new Entry(DateTime.Now, _mainRepository.StationsRepository.GetStationByName("Zmajevo"), "BG4321", VehicleType.Bus));
            _mainRepository.EntryRepository.Enqueue(new Entry(DateTime.Now, _mainRepository.StationsRepository.GetStationByName("Pirot istok"), "KG5678", VehicleType.Truck));
            _mainRepository.EntryRepository.Enqueue(new Entry(DateTime.Now, _mainRepository.StationsRepository.GetStationByName("Pojate"), "LO015", VehicleType.PassengerTruck));
            
        }
        
        public void Save()
        {
            _mainRepository.Save();
        }
    }
}