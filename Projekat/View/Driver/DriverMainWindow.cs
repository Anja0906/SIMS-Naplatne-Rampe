using System;
using System.Windows.Forms;
using SIMS.Controller;
using SIMS.Model;
using SIMS.Repository;

namespace SIMS.View
{
    public partial class DriverMainWindow : Form
    {
        private DriversController _driversController;
        private Driver _driver;
        private MainRepository _mainRepository;
        public Entry Entry;
        public DriverMainWindow(Driver driver, DriversController driversController, MainRepository mainRepository)
        {
            _driversController = driversController;
            _driver = driver;
            _mainRepository = mainRepository;
            Entry = null;
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            _driversController.Save();
            this.Hide();
            LogInWindow logInWindow = new LogInWindow();
            logInWindow.Show();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordWindow changePasswordWindow =
                new ChangePasswordWindow(_driver, new UsersController(_mainRepository));
            changePasswordWindow.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (Entry == null)
            {
                MessageBox.Show(@"You cannnot exit the road. You first need to enter the road!");
            }
            else
            {
                ExitChooseWindow exitChooseWindow = new ExitChooseWindow(_mainRepository, _driver, Entry);
                exitChooseWindow.Show();
            }
            
        }

        private void btnCalculatePrice_Click(object sender, EventArgs e)
        {
            PriceCalculator priceCalcWindow = new PriceCalculator(new PricelistRepository());
            priceCalcWindow.Show();
        }

        private void btnEnterTheRoad_Click(object sender, EventArgs e)
        {
            EntryChooseWindow entryChooseWindow = new EntryChooseWindow(_mainRepository, _driver, Entry, this);
            entryChooseWindow.Show();
        }

        private void btnBuyTag_Click(object sender, EventArgs e)
        {
            BuyTagWindow buyTagWindow = new BuyTagWindow(_driver, _driversController);
            buyTagWindow.Show();
        }
    }
}