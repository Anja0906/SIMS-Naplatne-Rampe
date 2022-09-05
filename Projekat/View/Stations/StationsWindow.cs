using System;
using System.Linq;
using System.Windows.Forms;
using SIMS.Controller;
using SIMS.Model;

namespace SIMS.View
{
    public partial class StationsWindow : Form
    {
        private StationsController _stationsController;
        public StationsWindow(StationsController stationsController)
        {
            _stationsController = stationsController;
            InitializeComponent();
            InitListBox();
        }

        private void InitListBox()
        {
            foreach (Station s in _stationsController.GetStations())
            {
                listBox1.Items.Add((s.Id, s.Name));
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddStationWindow addStationWindow = new AddStationWindow(null, _stationsController);
            addStationWindow.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            AddStationWindow addStationWindow = new AddStationWindow(_stationsController.GetStations().ElementAt(listBox1.SelectedIndex), _stationsController);
            addStationWindow.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _stationsController.DeleteStation(_stationsController.GetStations().ElementAt(listBox1.SelectedIndex));
            listBox1.Items.Clear();
            InitListBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BillingPlaceWindow billingPlaceWindow = new BillingPlaceWindow(_stationsController.GetStations().ElementAt(listBox1.SelectedIndex), _stationsController);
            billingPlaceWindow.Show();
        }

    }
}