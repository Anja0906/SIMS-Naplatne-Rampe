using System;
using System.Drawing;
using System.Windows.Forms;
using SIMS.Controller;
using SIMS.Model;
using SIMS.Repository;

namespace SIMS.View
{
    public partial class StationEWindow : Form
    {
        private MainRepository _mainRepository;
        private Entry _entry;
        private Exit _exit;
        private ExitController _exitController;
        private EntryController _entryController;
        private Driver _driver;
        
        public StationEWindow(Entry entry, MainRepository mainRepository, Exit exit, Driver driver)
        {
            _mainRepository = mainRepository;
            _entry = entry;
            _exit = exit;
            _exitController = new ExitController(_mainRepository);
            _entryController = new EntryController(_mainRepository);
            _driver = driver;
            InitializeComponent();
            InitForm();
        }

        private void InitTable()
        {
            InitMeasures();
            int i = 0;
            foreach (Place place in _entry.StationOfEntry.BillingPlaces)
            {
                DataGridViewColumn column = dataGridView1.Columns[i];
                column.Width = dataGridView1.Width/_entry.StationOfEntry.BillingPlaces.Count;
                InitType(place, i);
                InitUse(place, i);
                InitRamp(place, i);
                i++;
            }
            InitHeight();
            
        }

        private void InitMeasures()
        {
            dataGridView1.RowCount              = 4;
            dataGridView1.ColumnCount           = _entry.StationOfEntry.BillingPlaces.Count;
            dataGridView1.BorderStyle           = BorderStyle.FixedSingle;
            dataGridView1.ScrollBars            = ScrollBars.None;
            dataGridView1.Enabled               = true;
            dataGridView1.DefaultCellStyle.Font = new Font("Orbition", 8);
        }

        private void InitHeight()
        {
            for (int j = 0; j < 4; j++)
            {
                DataGridViewRow row = dataGridView1.Rows[j];
                row.Height = dataGridView1.Height/4;
            }
        }

        private void InitType(Place place, int i)
        {
            switch (place.VehicleType)
            {
                case VehicleType.Car:
                    dataGridView1.Rows[0].Cells[i].Value = "Car";
                    break;
                case VehicleType.Bus:
                    dataGridView1.Rows[0].Cells[i].Value = "Bus";
                    break;
                case VehicleType.Motorcycle:
                    dataGridView1.Rows[0].Cells[i].Value = "Moto";
                    break;
                case VehicleType.PassengerTruck:
                    dataGridView1.Rows[0].Cells[i].Value = "P Truck";
                    break;
                case VehicleType.Truck:
                    dataGridView1.Rows[0].Cells[i].Value = "Truck";
                    break;
                    
            }
        }

        private void InitUse(Place place, int i)
        {
            if (place.IsInUse.Equals(true))
            {
                dataGridView1.Rows[1].Cells[i].Style.BackColor = Color.ForestGreen;
            }
            else
            {
                dataGridView1.Rows[1].Cells[i].Style.BackColor = Color.IndianRed;
            }
        }

        private void InitRamp(Place place, int i)
        {
            if (place.Ramp.Equals(true))
            {
                dataGridView1.Rows[2].Cells[i].Style.BackColor = Color.ForestGreen;
            }
            else
            {
                dataGridView1.Rows[2].Cells[i].Style.BackColor = Color.IndianRed;
            }
        }

        private void InitForm()
        {
            InitTable();
            textBox1.Enabled = false;
            if (_entry != null)
            {
                textBox1.Text = _entry.StationOfEntry.Name;
            }

        }
        private void StationEWindow_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            lblTime.Text = datetime.ToShortDateString();
            lblTime.Text = lblTime.Text + ' ';
            lblTime.Text += datetime.ToLongTimeString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (_exit == null)
            {
                _entry.TimeOfEntry = DateTime.Now;
                _entryController.Add(_entry);
                this.Hide();
            }
            else
            {
                ChoosePayment(GetPlace());
            }
            
        }

        private void ChoosePayment(Place place)
        {
            if (IsValidPlace(place))
            {
                if (place.BillingType.Equals(BillingType.Electronic))
                {
                    foreach (Tag tag in _driver.Tags)
                    {
                        if (tag.NumberOfVehiclePlates.Equals(_exit.NumberOfVehiclePlates))
                        {
                            if (tag.BalanceOfMoney>_exit.Price)
                            {
                                tag.BalanceOfMoney -= _exit.Price;
                                this.Hide();
                                _exitController.Add(_exit);
                                RampRaising rampRaising = new RampRaising();
                                rampRaising.Show();
                            }
                            else
                            {
                                MessageBox.Show(@"You dont have enough money on your tag!");
                            }
                            
                        }
                        
                    }
                }
                else
                {
                    _exitController.Add(_exit);
                    DriversExchange driversExchange = new DriversExchange(_exit);
                    driversExchange.Show();
                    this.Hide();
                }
            }
        }

        private bool IsValidPlace(Place place)
        {
            return place.IsInUse;
        }

        private Place GetPlace()
        {
            if (dataGridView1.SelectedCells[0].RowIndex == 3)
            {
                return _exit.StationOfExit.BillingPlaces[dataGridView1.SelectedCells[0].ColumnIndex];
            }
            else
            {
                MessageBox.Show(@"Please choose the last row in this table!");
            }

            return null;
        }

        
    }
}