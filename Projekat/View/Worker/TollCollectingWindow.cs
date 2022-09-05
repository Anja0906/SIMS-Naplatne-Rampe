using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using SIMS.Controller;
using SIMS.Model;
using SIMS.Repository;

namespace SIMS.View
{
    public partial class TollCollectingWindow : Form
    {
        private Entry _entry;
        private Station _station;
        private double _price;
        private MainRepository _mainRepository;
        private ExitController _exitController;
        public TollCollectingWindow(MainRepository mainRepository, Entry entry, Station station, ExitController exitController)
        {
            InitFields(mainRepository, entry, station, exitController);
            InitializeComponent();
            InitWindow();
            InitFlag();

        }

        private void InitFields(MainRepository mainRepository, Entry entry, Station station, ExitController exitController)
        {
            _entry = entry;
            _mainRepository = mainRepository;
            _station = station;
            _exitController = exitController;
            _price = _mainRepository.PricelistRepository.Pricelist.CalculatePrice(_entry.StationOfEntry.Name, _station.Name,
                _entry.VehicleType);
        }

        private void InitFlag()
        {
            if (_exitController.IsSpeedExceeded(_entry.TimeOfEntry.Subtract(DateTime.Now), new Exit(DateTime.Now, _entry.StationOfEntry, _station, _price, _entry.NumberOfVehiclePlates,
                    _entry.VehicleType)))
            {
                tbSpeedLimit.BackColor = Color.Red;
            }
            else
            {
                tbSpeedLimit.BackColor = Color.Green;
            }
        }

        private void InitWindow()
        {
            cbCategory.DataSource = Enum.GetValues(typeof(VehicleType));
            tbEntryPlace.Text = _entry.StationOfEntry.Name;
            tbEntryTime.Text = _entry.TimeOfEntry.ToString("g");
            tbNumOfPlates.Text = _entry.NumberOfVehiclePlates;
            cbCategory.SelectedItem = _entry.VehicleType;
            lblPrice.Text += " " + _price;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            _exitController.Add(new Exit(DateTime.Now, _entry.StationOfEntry, _station, _price, _entry.NumberOfVehiclePlates,
                _entry.VehicleType));
            this.Hide();
            MessageBox.Show(@"You have successfully passed driver number: " + _entry.NumberOfVehiclePlates);
        }

        private void tbDriversAmount_TextChanged(object sender, EventArgs e)
        {
            tbChange.Text = (Double.Parse(tbDriversAmount.Text) - _price).ToString();
        }
    }
}