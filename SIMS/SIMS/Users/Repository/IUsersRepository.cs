using SIMS.Model;

namespace SIMS.Repository
{
    public interface IUsersRepository
    {
        User GetUserByEmail(string email);
        void Update(User newUser);
        void Save();
    }
}