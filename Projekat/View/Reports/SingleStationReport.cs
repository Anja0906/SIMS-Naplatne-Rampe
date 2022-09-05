using System;
using System.Windows.Forms;
using SIMS.Repository;

namespace SIMS.View
{
    public partial class SingleStationReport : Form
    {
        private MainRepository _mainRepository;
        public SingleStationReport(MainRepository mainRepository)
        {
            _mainRepository = mainRepository;
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports(_mainRepository, tbName.Text, dtpFrom.Value, dtpTo.Value, 2);
            reports.Show();
            this.Hide();
        }
    }
}