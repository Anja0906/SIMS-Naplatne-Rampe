using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using SIMS.Model;

namespace SIMS.Repository
{
    public class PricelistRepository : IPricelistRepository
    {
        public Pricelist Pricelist;
        private List<Pricelist> _deletedPricelists;
        public PricelistRepository()
        {
            string json = File.ReadAllText(@"..\..\Data\DeletedPricelists.json");
            List<Pricelist> deletedPricelists = JsonConvert.DeserializeObject<List<Pricelist>>(json);
            _deletedPricelists = deletedPricelists;
            string json1 = File.ReadAllText(@"..\..\Data\Pricelist.json");
            Pricelist pricelist = JsonConvert.DeserializeObject<Pricelist>(json1);
            Pricelist = pricelist;
            
        }
        
        public void UpdatePricelist(Pricelist pricelist)
        {
            _deletedPricelists.Add(Pricelist);
            Pricelist = pricelist;
            this.Save();
        }
        
        public void Save()
        {
            File.WriteAllText(@"..\..\Data\DeletedPricelists.json", JsonConvert.SerializeObject(_deletedPricelists));
            File.WriteAllText(@"..\..\Data\Pricelist.json", JsonConvert.SerializeObject(Pricelist));
        }
        
    }
}