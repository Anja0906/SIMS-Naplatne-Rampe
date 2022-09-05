using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using SIMS.Model;

namespace SIMS.Repository
{
    public class WorkersRepository : IWorkersRepository
    {
        private List<Worker> _workers;

        public WorkersRepository()
        {
            string json = File.ReadAllText(@"..\..\Data\Workers.json");
            List<Worker> workers = JsonConvert.DeserializeObject<List<Worker>>(json);
            _workers = workers;
        }
        
        public Worker GetWorker(User user)
        {
            foreach (Worker worker in _workers)
            {
                if (worker.Email.Equals(user.Email))
                {
                    return worker;
                }
            }

            return null;
        }
        
        public Worker GetWorkerByEmail(string email)
        {
            foreach (Worker worker in _workers)
            {
                if (worker.Email.Equals(email))
                {
                    return worker;
                }
            }

            return null;
        }
        public void Update(Worker newWorker)
        {
            Worker worker = GetWorkerByEmail(newWorker.Email);
            _workers.Remove(worker);
            _workers.Add(newWorker);
            
        }
        
        public void Save()
        {
            File.WriteAllText(@"..\..\Data\Workers.json", JsonConvert.SerializeObject(_workers));
        }
    }
}