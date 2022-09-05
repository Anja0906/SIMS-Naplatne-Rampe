using SIMS.Model;

namespace SIMS.Repository
{
    public interface IManagersRepository
    {
        Manager GetManager(User user);
        Manager GetManagerByEmail(string email);
        void Update(Manager newManager);
        void Save();
    }
}