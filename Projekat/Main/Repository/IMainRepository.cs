namespace SIMS.Repository
{
    public interface IMainRepository
    {
        AdministratorsRepository AdministratorsRepository { get; set; }
        DriversRepository DriversRepository { get; set; }
        ManagersRepository ManagersRepository { get; set; }
        StationsRepository StationsRepository { get; set; }
        UsersRepository UsersRepository { get; set; }
        WorkersRepository WorkersRepository { get; set; }
        ExitRepository ExitRepository { get; set; }
        PricelistRepository PricelistRepository { get; set; }
        EntryRepository EntryRepository { get; set; }
        void Save();
    }
}