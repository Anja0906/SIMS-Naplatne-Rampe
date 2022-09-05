using System;
using System.Windows.Forms;

namespace SIMS.View
{
    public partial class InformThePoliceWindow : Form
    {
        public InformThePoliceWindow()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show(@"You have successfully reported thr police for this driver!");
        }
    }
}