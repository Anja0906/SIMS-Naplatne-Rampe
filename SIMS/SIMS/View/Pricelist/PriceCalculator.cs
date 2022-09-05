using System;
using System.Windows.Forms;
using SIMS.Model;
using SIMS.Repository;

namespace SIMS.View
{
    public partial class PriceCalculator : Form
    {
        private Pricelist _pricelist;
        public PriceCalculator(PricelistRepository pricelistRepository)
        {
            _pricelist = pricelistRepository.Pricelist;
            InitializeComponent();
            InitComboBoxes();
        }

        private void InitComboBoxes()
        {
            foreach (string place in _pricelist.GetPlaces())
            {
                cbEntry.Items.Add(place);
                cbExit.Items.Add(place);
            }
            cbVehicleType.DataSource = Enum.GetValues(typeof(VehicleType));
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            double price = _pricelist.CalculatePrice(cbEntry.SelectedItem.ToString(), cbExit.SelectedItem.ToString(),
                (VehicleType)cbVehicleType.SelectedValue);
            tbPrice.Text = "" + price + "";

        }
    }
}