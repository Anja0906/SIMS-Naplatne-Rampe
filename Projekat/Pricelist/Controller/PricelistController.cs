using System.Collections.Generic;
using SIMS.Model;
using SIMS.Repository;

namespace SIMS.Controller
{
    public class PricelistController : IPricelistController
    {
        private MainRepository _mainRepository;

        public PricelistController(MainRepository mainRepository)
        {
            _mainRepository = mainRepository;
        }

        public void UpdatePricelist(double coefficient, Pricelist pricelist)
        {
            pricelist.Coefficient = coefficient;
            List<Section> sections = new List<Section>();
            foreach (Section section in pricelist.Sections)
            {
                section.Ia *= coefficient;
                section.I *= coefficient;
                section.II *= coefficient;
                section.III *= coefficient;
                section.IV *= coefficient;
                sections.Add(section);
            }
            pricelist.Sections = sections;
            _mainRepository.PricelistRepository.UpdatePricelist(pricelist);
        }
    }
}