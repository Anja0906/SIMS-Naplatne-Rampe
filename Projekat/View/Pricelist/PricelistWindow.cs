using System;
using System.Windows.Forms;
using SIMS.Controller;
using SIMS.Model;
using SIMS.Repository;

namespace SIMS.View
{
    public partial class PricelistWindow : Form
    {
        private Pricelist _pricelist;
        private MainRepository _mainRepository;
        public PricelistWindow(MainRepository mainRepository)
        {
            _mainRepository = mainRepository;
            _pricelist = _mainRepository.PricelistRepository.Pricelist;
            InitializeComponent();
            InitComponents();
        }

        private void InitComponents()
        {
            lblDateOfValidity.Text += " " + _pricelist.EffectiveDate;
            foreach (string place1 in _pricelist.GetPlaces())
            {
                foreach (string place2 in _pricelist.GetPlaces())
                {
                    if (place1 != place2)
                    {
                        
                        listBox1.Items.Add(BuildRow(place1, place2));
                    }
                }
            }
        }

        private string BuildRow(string place1, string place2)
        {
            string row = place1 + " | " + place2;
            row += " | " + _pricelist.CalculatePrice(place1, place2, VehicleType.Motorcycle);
            row += " | " + _pricelist.CalculatePrice(place1, place2, VehicleType.Car);
            row += " | " + _pricelist.CalculatePrice(place1, place2, VehicleType.Bus);
            row += " | " + _pricelist.CalculatePrice(place1, place2, VehicleType.PassengerTruck);
            row += " | " + _pricelist.CalculatePrice(place1, place2, VehicleType.Truck);
            return row;
        }

        private void btnChangePricelist_Click(object sender, EventArgs e)
        {
            this.Hide();
            PricelistChanging pricelistChanging = new PricelistChanging(_mainRepository, new PricelistController(_mainRepository));
            pricelistChanging.Show();
        }
    }
}