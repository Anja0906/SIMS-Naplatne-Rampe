using SIMS.Model;

namespace SIMS.Repository
{
    public interface IEntryRepository
    {
        void Enqueue(Entry entry);
        Entry Dequeue();
    }
}