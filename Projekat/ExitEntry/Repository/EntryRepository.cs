using System;
using System.Collections.Generic;
using Bogus.DataSets;
using SIMS.Model;

namespace SIMS.Repository
{
    public class EntryRepository : IEntryRepository
    {
        private Queue<Entry> _entries = new Queue<Entry>();
        public void Enqueue(Entry entry)
        {
            _entries.Enqueue(entry);
        }

        public Entry Dequeue()
        {
            return _entries.Dequeue();
        }
    }
}