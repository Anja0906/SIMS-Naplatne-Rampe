using System.Collections.Generic;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using SIMS.Model;

namespace SIMS.Repository
{
    public class ExitRepository : IExitRepository
    {
        private List<Exit> _exits;

        public ExitRepository()
        {
            string json = File.ReadAllText(@"..\..\Data\Payments.json");
            List<Exit> exits = JsonConvert.DeserializeObject<List<Exit>>(json);
            _exits = exits;
        }

        public void Add(Exit exit)
        {
            _exits.Add(exit);
        }

        public List<Exit> GetExits()
        {
            return _exits;
        }

        public void Save()
        {
            File.WriteAllText(@"..\..\Data\Payments.json", JsonConvert.SerializeObject(_exits));
        }
    }
}