using System;
using System.Windows.Forms;
using SIMS.Model;

namespace SIMS.View
{
    public partial class DriversExchange : Form
    {
        private Exit _exit;
        public DriversExchange(Exit exit)
        {
            _exit = exit;
            InitializeComponent();
            InitPrice();
        }

        private void InitPrice()
        {
            tbPrice.Text += _exit.Price;
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Double.Parse(tbAmount.Text) < _exit.Price)
            {
                MessageBox.Show(@"You dont payed enough!");
            }
            else
            {
                this.Hide();
                MessageBox.Show(@"Your exchange is: " + (Double.Parse(tbAmount.Text) - _exit.Price));
                RampRaising rampRaising = new RampRaising();
                rampRaising.Show();
            }
        }
    }
}