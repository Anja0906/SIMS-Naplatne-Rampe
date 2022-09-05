using System;
using System.Windows.Forms;
using SIMS.Repository;

namespace SIMS.View
{
    public partial class ReportsWindow : Form
    {
        private MainRepository _mainRepository;
        public ReportsWindow(MainRepository mainRepository)
        {
            _mainRepository = mainRepository;
            InitializeComponent();
        }

        private void btnSingleStations_Click(object sender, EventArgs e)
        {
            SingleStationReport singleStationReport = new SingleStationReport(_mainRepository);
            singleStationReport.Show();
        }

        private void btnAllStations_Click(object sender, EventArgs e)
        {
            AllStationsReport allStationsReport = new AllStationsReport(_mainRepository);
            allStationsReport.Show();
        }
    }
}