using System.Linq;
using System.Windows.Forms;
using SIMS.Controller;
using SIMS.Model;

namespace SIMS.View
{
    public partial class BillingPlaceWindow : Form
    {
        private StationsController _stationsController;
        private Station _station;
        public BillingPlaceWindow(Station station, StationsController stationsController)
        {
            _stationsController = stationsController;
            _station = station;
            InitializeComponent();
            InitListBox();
        }
        private void InitListBox()
        {
            for (int i = 0; i < _stationsController.GetPlaces(_station).Count; i++)
            {
                listBox1.Items.Add( _stationsController.GetPlaces(_station).ElementAt(i).ToString());
            }
        }
    }
}