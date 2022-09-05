using System;
using SIMS.Model;
using SIMS.Repository;

namespace SIMS.Controller
{
    public class UsersController : IUsersController
    {
        private MainRepository _mainRepository;

        public UsersController(MainRepository mainRepository)
        {
            _mainRepository = mainRepository;
        }

        public bool CheckUser(string email, string password)
        {
            User user = _mainRepository.UsersRepository.GetUserByEmail(email);
            if (user.Equals(null))
            {
                throw new NullReferenceException();
            }
            else
            {
                if (user.Password.Equals(password))
                {
                    return true;
                }

            }

            return false;
        }

        public User GetUserByEmail(string email)
        {
            return _mainRepository.UsersRepository.GetUserByEmail(email);
        }

        public void ChangePassword(string email, string newPassword)
        {
            User user = GetUserByEmail(email);
            user.Password = newPassword;
            _mainRepository.UsersRepository.Update(user);
            switch (user.Role)
            {
                case Role.Administrator:
                    Administrator administrator = _mainRepository.AdministratorsRepository.GetAdministrator(user);
                    _mainRepository.AdministratorsRepository.Update(administrator);
                    break;
                case Role.Driver:
                    Driver driver = _mainRepository.DriversRepository.GetDriver(user);
                    _mainRepository.DriversRepository.Update(driver);
                    break;
                case Role.Manager:
                    Manager manager = _mainRepository.ManagersRepository.GetManager(user);
                    _mainRepository.ManagersRepository.Update(manager);
                    break;
                case Role.Worker:
                    Worker worker = _mainRepository.WorkersRepository.GetWorker(user);
                    _mainRepository.WorkersRepository.Update(worker);
                    break;
            }
        }
        
        public void Save()
        {
            _mainRepository.Save();
        }
    }
}