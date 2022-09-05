using System;
using System.Windows.Forms;
using SIMS.Repository;

namespace SIMS.View
{
    public partial class AllStationsReport : Form
    {
        private MainRepository _mainRepository;
        public AllStationsReport(MainRepository mainRepository)
        {
            _mainRepository = mainRepository;
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports(_mainRepository, " ", dtpFrom.Value, dtpTo.Value, 1);
            reports.Show();
            this.Hide();
        }
    }
}