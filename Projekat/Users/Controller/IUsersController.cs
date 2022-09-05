using SIMS.Model;

namespace SIMS.Controller
{
    public interface IUsersController
    {
        bool CheckUser(string email, string password);
        User GetUserByEmail(string email);
        void ChangePassword(string email, string newPassword);
        void Save();
    }
}