using System;
using System.Windows.Forms;
using SIMS.Model;
using SIMS.Repository;

namespace SIMS.View
{
    public partial class ExitChooseWindow : Form
    {
        private Pricelist _pricelist;
        private Driver _driver;
        private MainRepository _mainRepository;
        private Entry _entry;
        public ExitChooseWindow(MainRepository mainRepository, Driver driver, Entry entry)
        {
            _mainRepository = mainRepository;
            _pricelist = _mainRepository.PricelistRepository.Pricelist;
            _driver = driver;
            _entry = entry;
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

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            StationEWindow stationEWindow = new StationEWindow(_entry, _mainRepository, new Exit(DateTime.Now, _entry.StationOfEntry, _mainRepository.StationsRepository.GetStationByName(cbStation.SelectedItem.ToString()), _pricelist.CalculatePrice(_entry.StationOfEntry.Name, cbStation.SelectedItem.ToString(), _entry.VehicleType), _entry.NumberOfVehiclePlates, _entry.VehicleType), _driver);
            stationEWindow.Show();
        }
    }
}