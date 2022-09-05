using System;
using System.Windows.Forms;
using SIMS.Controller;
using SIMS.Model;
using SIMS.Repository;

namespace SIMS.View
{
    public partial class ManagerMainWindow : Form
    {
        private ManagersController _managersController;
        private Manager _manager;
        private MainRepository _mainRepository;
        public ManagerMainWindow(MainRepository mainRepository, Manager manager, ManagersController managersController)
        {
            _mainRepository = mainRepository;
            _managersController = managersController;
            _manager = manager;
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            _managersController.Save();
            this.Hide();
            LogInWindow logInWindow = new LogInWindow();
            logInWindow.Show();
        }

        private void btnStations_Click(object sender, EventArgs e)
        {
            StationsWindow stationsWindow = new StationsWindow(new StationsController(_mainRepository));
            stationsWindow.Show();
        }

        private void btnDevices_Click(object sender, EventArgs e)
        {
            CheckDevices checkDevices = new CheckDevices(new StationsController(_mainRepository));
            checkDevices.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportsWindow reportsWindow = new ReportsWindow(_mainRepository);
            reportsWindow.Show();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordWindow changePasswordWindow =
                new ChangePasswordWindow(_manager, new UsersController(_mainRepository));
            changePasswordWindow.Show();
        }
    }
}