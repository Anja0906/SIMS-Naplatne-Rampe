using SIMS.Repository;

namespace SIMS.Controller
{
    public class ManagersController : IManagersController
    {
        private ManagersRepository _managersRepository;
        private MainRepository _mainRepository;

        public ManagersController(MainRepository mainRepository)
        {
            _managersRepository = mainRepository.ManagersRepository;
            _mainRepository = mainRepository;
        }
        
        public void Save()
        {
            _mainRepository.Save();
        }
    }
}