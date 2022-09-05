using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SIMS.Controller;
using SIMS.Model;
using SIMS.Repository;

namespace SIMS.View
{
    public partial class AddStationWindow : Form
    {
        private StationsController _stationsController;
        private Station _station;
        public AddStationWindow(Station station, StationsController stationsController)
        {
            _stationsController = stationsController;
            _station = station;
            InitializeComponent();
            InitWindow();
        }

        private void InitListBox()
        {
            listBox1.Items.Clear();
            foreach (Place place in _station.BillingPlaces)
            {
                listBox1.Items.Add( place.ToString());
            }
        }

        private void InitWindow()
        {
            if (_station!=null)
            {
                tbId.Text = _station.Id;
                tbId.Enabled = false;
                tbName.Text = _station.Name;
                InitListBox();
            }
            else
            {
                btnDeletePlace.Enabled = false;
                btnUpdatePlace.Enabled = false;
            }
        }

        private void btnAddPlace_Click(object sender, EventArgs e)
        {
            if (_station!=null)
            {
                _station = _stationsController.GetStationById(tbId.Text);
                _station.Name = tbName.Text;
            }
            else
            {
                _station = new Station(tbId.Text, tbName.Text, new List<Place>());
            }
            AddPlaceWindow addPlaceWindow = new AddPlaceWindow(null, _station, _stationsController);
            addPlaceWindow.Show();
            this.Hide();
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (_station.Equals(null))
            {
                MessageBox.Show(@"Your station must have at least one billing place!");
            }
            else
            {
                this.Hide();
                _station.Name = tbName.Text;
                _stationsController.UpdateStation(_station);
                StationsWindow stationsWindow = new StationsWindow(_stationsController);
                stationsWindow.Show();
            }
            
        }

        private void btnUpdatePlace_Click(object sender, EventArgs e)
        {
            Place place = _stationsController.GetPlaces(_station).ElementAt(listBox1.SelectedIndex);
            AddPlaceWindow addPlaceWindow = new AddPlaceWindow(place, _station, _stationsController);
            addPlaceWindow.Show();
            this.Hide();
        }

        private void btnDeletePlace_Click(object sender, EventArgs e)
        {
            Place place = _stationsController.GetPlaces(_station).ElementAt(listBox1.SelectedIndex);
            _stationsController.DeletePlace(_station, place);
            InitListBox();
        }
    }
}