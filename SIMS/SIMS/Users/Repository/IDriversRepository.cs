using SIMS.Model;

namespace SIMS.Repository
{
    public interface IDriversRepository
    {
        Driver GetDriver(User user);

        Driver GetDriverByEmail(string email);
        void Update(Driver newDriver);

        void Save();
    }
}