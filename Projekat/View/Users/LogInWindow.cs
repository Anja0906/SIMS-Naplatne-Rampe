using System;
using System.Windows.Forms;
using SIMS.Controller;
using SIMS.Model;
using SIMS.Repository;

namespace SIMS.View
{
    public partial class LogInWindow : Form
    {
        private MainRepository _mainRepository;
        private UsersController _usersController;
        public LogInWindow()
        {
            _mainRepository = new MainRepository();
            _usersController = new UsersController(_mainRepository);
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                bool isUser = _usersController.CheckUser(txtBoxEmail.Text, txtBoxPassword.Text);
                if (isUser)
                {
                    User user = _usersController.GetUserByEmail(txtBoxEmail.Text);
                    switch (user.Role)
                    {
                        case Role.Manager:
                            Manager manager = _mainRepository.ManagersRepository.GetManager(user);
                            ManagerMainWindow managerMainWindow = new ManagerMainWindow(_mainRepository, manager, new ManagersController(_mainRepository));
                            managerMainWindow.Show();
                            this.Dispose(false);
                            break;
                        case Role.Administrator:
                            Administrator administrator =
                                _mainRepository.AdministratorsRepository.GetAdministrator(user);
                            AdministratorMainWondow administratorMainWondow = new AdministratorMainWondow(administrator, new AdiminstratorsController(_mainRepository), _mainRepository);
                            administratorMainWondow.Show();
                            this.Dispose(false);
                            break;
                        case Role.Driver:
                            Driver driver = _mainRepository.DriversRepository.GetDriver(user);
                            DriverMainWindow driverMainWindow = new DriverMainWindow(driver, new DriversController(_mainRepository), _mainRepository);
                            driverMainWindow.Show();
                            this.Dispose(false);
                            break;
                        case Role.Worker:
                            Worker worker = _mainRepository.WorkersRepository.GetWorker(user);
                            WorkerMainWindow workerMainWindow = new WorkerMainWindow(worker, new WorkersController(_mainRepository), _mainRepository);
                            workerMainWindow.Show();
                            this.Dispose(false);
                            break;
                    }
                
                }
                else
                {
                    MessageBox.Show(@"Wrong password!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"User does not exist!");
            }
            
        }

    }
}