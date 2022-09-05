using System;
using System.Windows.Forms;
using SIMS.Controller;
using SIMS.Model;

namespace SIMS.View
{
    public partial class BuyTagWindow : Form
    {
        private Driver _driver;
        private DriversController _driversController;
        public BuyTagWindow(Driver driver, DriversController driversController)
        {
            _driver = driver;
            _driversController = driversController;
            InitializeComponent();
            cbVehicleType.DataSource = Enum.GetValues(typeof(VehicleType));
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            _driversController.BuyTag(_driver, new Tag("0000", (VehicleType) cbVehicleType.SelectedItem, tbNumberOfPlates.Text,
                Double.Parse(textBox1.Text)));
            this.Hide();
        }
    }
}