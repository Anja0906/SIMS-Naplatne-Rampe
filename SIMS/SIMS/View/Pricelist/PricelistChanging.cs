using System;
using System.Windows.Forms;
using SIMS.Controller;
using SIMS.Model;
using SIMS.Repository;

namespace SIMS.View
{
    public partial class PricelistChanging : Form
    {
        private PricelistController _pricelistController;
        private MainRepository _mainRepository;
        
        public PricelistChanging(MainRepository mainRepository, PricelistController pricelistController)
        {
            _mainRepository = mainRepository;
            _pricelistController = pricelistController;
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Pricelist pricelist = new Pricelist(dtpStartOfValidity.Value, Double.Parse(tbCoefficent.Text), _mainRepository.PricelistRepository.Pricelist.Sections, _mainRepository.PricelistRepository.Pricelist.Places);
            _pricelistController.UpdatePricelist(Double.Parse(tbCoefficent.Text), pricelist);
            this.Hide();
            MessageBox.Show(@"Your new pricelist is successfully updated!");  
        }
    }
}