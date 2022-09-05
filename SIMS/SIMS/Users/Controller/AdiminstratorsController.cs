using System.Xml.Linq;
using SIMS.Model;
using SIMS.Repository;

namespace SIMS.Controller
{
    
    public class AdiminstratorsController : IAdiminstratorsController
    {
        private AdministratorsRepository _administratorsRepository;
        private MainRepository _mainRepository;

        public AdiminstratorsController(MainRepository mainRepository)
        {
            _administratorsRepository = mainRepository.AdministratorsRepository;
            _mainRepository = mainRepository;
        }
        public void ChangePassword(string email, string newPassword)
        {
            Administrator administrator = _administratorsRepository.GetAdministratorByEmail(email);
            administrator.Password = newPassword;
            _administratorsRepository.Update(administrator);
            
        }

        public void Save()
        {
            _mainRepository.Save();
        }
    }
}