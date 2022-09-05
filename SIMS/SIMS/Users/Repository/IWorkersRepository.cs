using SIMS.Model;

namespace SIMS.Repository
{
    public interface IWorkersRepository
    {
        Worker GetWorker(User user);
        Worker GetWorkerByEmail(string email);
        void Update(Worker newWorker);
        void Save();
    }
}