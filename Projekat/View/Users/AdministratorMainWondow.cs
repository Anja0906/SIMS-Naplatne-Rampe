using System;
using System.Windows.Forms;
using SIMS.Controller;
using SIMS.Model;
using SIMS.Repository;

namespace SIMS.View
{
    public partial class AdministratorMainWondow : Form
    {
        private AdiminstratorsController _adiminstratorsController;
        private Administrator _administrator;
        private MainRepository _mainRepository;
        public AdministratorMainWondow(Administrator administrator, AdiminstratorsController adiminstratorsController, MainRepository mainRepository)
        {
            _adiminstratorsController = adiminstratorsController;
            _administrator = administrator;
            _mainRepository = mainRepository;
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            _adiminstratorsController.Save();
            this.Hide();
            LogInWindow logInWindow = new LogInWindow();
            logInWindow.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChangePasswordWindow changePasswordWindow =
                new ChangePasswordWindow(_administrator,  new UsersController(_mainRepository));
            changePasswordWindow.Show();
        }

        private void btnPricelist_Click(object sender, EventArgs e)
        {
            PricelistWindow pricelistWindow = new PricelistWindow(_mainRepository);
            pricelistWindow.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            AllStationsReport allStationsReport = new AllStationsReport(_mainRepository);
            allStationsReport.Show();
        }

        private void btnAddPlace_Click(object sender, EventArgs e)
        {
            AddPlaceWindow addPlaceWindow =
                new AddPlaceWindow(null, _administrator.Station, new StationsController(_mainRepository));
            addPlaceWindow.Show();
        }
    }
}