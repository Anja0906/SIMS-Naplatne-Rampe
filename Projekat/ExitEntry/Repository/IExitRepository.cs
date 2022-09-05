using System.Collections.Generic;
using SIMS.Model;

namespace SIMS.Repository
{
    public interface IExitRepository
    {
        void Add(Exit exit);
        List<Exit> GetExits();
        void Save();
    }
}