using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SIMS.Controller;
using SIMS.Model;

namespace SIMS.View
{
    public partial class DevicesWindow : Form
    {
        private Station _station;
        private StationsController _stationsController;
        public DevicesWindow(Station station, StationsController stationsController)
        {
            _stationsController = stationsController;
            _station = station;
            InitializeComponent();
            InitListBoxes();
        }

        private void InitListBoxes()
        {
            lbBroken.Items.Clear();
            lbInUse.Items.Clear();
            foreach (Place place in _station.BillingPlaces)
            {
                if (place.IsInUse)
                {
                    lbInUse.Items.Add((place.Id, place.BillingType, place.VehicleType));
                }
                else
                {
                    lbBroken.Items.Add((place.Id, place.BillingType, place.VehicleType));
                }
            }
            
        }

        private void btnRepair_Click(object sender, EventArgs e)
        {
            string id = _stationsController.getIdFromListBox(lbBroken.Items[lbBroken.SelectedIndex].ToString());
            _stationsController.RepairPlace(_station, id);
            InitListBoxes();
        }
    }
}