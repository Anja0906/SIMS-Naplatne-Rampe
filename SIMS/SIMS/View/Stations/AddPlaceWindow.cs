using System;
using System.Windows.Forms;
using SIMS.Controller;
using SIMS.Model;

namespace SIMS.View
{
    public partial class AddPlaceWindow : Form
    {
        private StationsController _stationsController;
        private Station _station;
        private Place _place;
        public AddPlaceWindow(Place place, Station station, StationsController stationsController)
        {
            _stationsController = stationsController;
            _station = station;
            _place = place;
            InitializeComponent();
            InitWindow();
        }

        private void InitWindow()
        {
            InitComboBoxes();
            if (_place!=null)
            {
                tbId.Text = _place.Id;
                cbBillingType.SelectedItem = _place.BillingType;
                cbVehicleType.SelectedItem = _place.VehicleType;
                tbId.Enabled = false;
            }
        }

        private void InitComboBoxes()
        {
            cbBillingType.DataSource = Enum.GetValues(typeof(BillingType));
            cbVehicleType.DataSource = Enum.GetValues(typeof(VehicleType));
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (_place != null)
            {
                _stationsController.UpdatePlace(_station, new Place(_place.Id, (BillingType) cbBillingType.SelectedItem, (VehicleType) cbVehicleType.SelectedItem));
            }
            else
            {
                _stationsController.AddPlace(_station, new Place(tbId.Text, (BillingType)cbBillingType.SelectedItem, (VehicleType) cbVehicleType.SelectedItem));
            }
            AddStationWindow addStationWindow = new AddStationWindow(_station, _stationsController);
            addStationWindow.Show();
            this.Hide();
        }
    }
}