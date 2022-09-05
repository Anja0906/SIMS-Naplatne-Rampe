using System;
using System.Windows.Forms;
using SIMS.Controller;
using SIMS.Model;
using SIMS.Repository;

namespace SIMS.View
{
    public partial class EntryChooseWindow : Form
    {
        private Pricelist _pricelist;
        private Driver _driver;
        private MainRepository _mainRepository;
        private Entry _entry;
        private DriverMainWindow _driverMain;
        public EntryChooseWindow(MainRepository mainRepository, Driver driver, Entry entry, DriverMainWindow driverMainWindow)
        {
            _mainRepository = mainRepository;
            _pricelist = _mainRepository.PricelistRepository.Pricelist;
            _driver = driver;
            _entry = entry;
            _driverMain = driverMainWindow;
            InitializeComponent();
            InitForm();
        }

        private void InitForm()
        {
            foreach (string place in _pricelist.GetPlaces())
            {
                cbStation.Items.Add(place);
            }
            cbVehicleType.DataSource = Enum.GetValues(typeof(VehicleType));
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            _entry = new Entry(DateTime.Now,
                _mainRepository.StationsRepository.GetStationByName(cbStation.SelectedItem.ToString()),
                _driver.Tags[0].NumberOfVehiclePlates, (VehicleType) cbVehicleType.SelectedValue);
            _driverMain.Entry = _entry;
            StationEWindow stationEWindow = new StationEWindow(_entry, _mainRepository, null, _driver);
            stationEWindow.Show();
            this.Hide();
        }
    }
}