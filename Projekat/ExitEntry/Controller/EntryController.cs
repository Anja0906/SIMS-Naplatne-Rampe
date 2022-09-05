using SIMS.Model;
using SIMS.Repository;

namespace SIMS.Controller
{
    public class EntryController : IEntryController
    {
        private MainRepository _mainRepository;

        public EntryController(MainRepository mainRepository)
        {
            _mainRepository = mainRepository;
        }

        public void Add(Entry entry)
        {
            _mainRepository.EntryRepository.Enqueue(entry);
        }
        
        public void Save()
        {
            _mainRepository.Save();
        }

        
    }
}