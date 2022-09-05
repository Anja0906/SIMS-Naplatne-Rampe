using SIMS.Model;

namespace SIMS.Repository
{
    public interface IPricelistRepository
    {
        void UpdatePricelist(Pricelist pricelist);
        void Save();
    }
}