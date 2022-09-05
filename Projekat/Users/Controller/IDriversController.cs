using SIMS.Model;

namespace SIMS.Controller
{
    public interface IDriversController
    {
        void BuyTag(Driver driver, Tag tag);
        void Save();
    }
}