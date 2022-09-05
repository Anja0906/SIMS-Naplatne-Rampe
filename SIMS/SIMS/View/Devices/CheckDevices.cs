using System;
using System.Windows.Forms;
using SIMS.Controller;
using SIMS.Model;

namespace SIMS.View
{
    public partial class CheckDevices : Form
    {
        private StationsController _stationsController;
        public CheckDevices(StationsController stationsController)
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

        private void btnChoose_Click(object sender, EventArgs e)
        {
            DevicesWindow devicesWindow = new DevicesWindow(_stationsController.GetStations()[listBox1.SelectedIndex], _stationsController);
            devicesWindow.Show();
        }
    }
}