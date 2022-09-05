namespace SIMS.Controller
{
    public interface IAdiminstratorsController
    {
        void ChangePassword(string email, string newPassword);
        void Save();
    }
}