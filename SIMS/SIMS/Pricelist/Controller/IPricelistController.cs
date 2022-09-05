using SIMS.Model;

namespace SIMS.Controller
{
    public interface IPricelistController
    {
        void UpdatePricelist(double coefficient, Pricelist pricelist);
    }
}