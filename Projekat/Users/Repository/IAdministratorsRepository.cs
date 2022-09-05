using SIMS.Model;

namespace SIMS.Repository
{
    public interface IAdministratorsRepository
    {
        Administrator GetAdministrator(User user);
        Administrator GetAdministratorByEmail(string email);
        void Update(Administrator newAdministrator);
        void Save();
    }
}