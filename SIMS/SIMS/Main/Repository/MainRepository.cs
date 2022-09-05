namespace SIMS.Repository
{
    public class MainRepository : IMainRepository
    {
        public AdministratorsRepository AdministratorsRepository { get; set; }
        public DriversRepository DriversRepository { get; set; }
        public ManagersRepository ManagersRepository { get; set; }
        public StationsRepository StationsRepository { get; set; }
        public UsersRepository UsersRepository { get; set; }

        public WorkersRepository WorkersRepository { get; set; }
        public ExitRepository ExitRepository { get; set; }
        public PricelistRepository PricelistRepository { get; set; }
        public EntryRepository EntryRepository { get; set; }
        
        public MainRepository()
        {
            AdministratorsRepository = new AdministratorsRepository();
            DriversRepository = new DriversRepository();
            ManagersRepository = new ManagersRepository();
            StationsRepository = new StationsRepository();
            UsersRepository = new UsersRepository();
            WorkersRepository = new WorkersRepository();
            ExitRepository = new ExitRepository();
            PricelistRepository = new PricelistRepository();
            EntryRepository = new EntryRepository();
        }

        public void Save()
        {
            AdministratorsRepository.Save();
            DriversRepository.Save();
            ManagersRepository.Save();
            StationsRepository.Save();
            UsersRepository.Save();
            WorkersRepository.Save();
            ExitRepository.Save();
            PricelistRepository.Save();
        }
    }
}