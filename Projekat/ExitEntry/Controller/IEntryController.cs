using SIMS.Model;

namespace SIMS.Controller
{
    public interface IEntryController
    {
        void Add(Entry entry);
        void Save();
    }
}