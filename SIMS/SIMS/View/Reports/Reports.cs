using System;
using System.Windows.Forms;
using SIMS.Model;
using SIMS.Repository;

namespace SIMS.View
{
    public partial class Reports : Form
    {
        private MainRepository _mainRepository;
        private DateTime _startDate;
        private DateTime _stopDate;
        private string _stationsName;
        private int _flag;
        public Reports(MainRepository mainRepository, string stationsName, DateTime start, DateTime end, int flag )
        {
            _mainRepository = mainRepository;
            _stationsName = stationsName;
            _startDate = start;
            _stopDate = end;
            _flag = flag;
            InitializeComponent();
            InitListBox();
        }

        private void InitListBox()
        {
            if (_flag == 1)
            {
                InitListBox1();
            }
            
            else if (_flag == 2)
            {
                InitListBox2();
            }
        }

        private void InitListBox1()
        {
            double wholeIncome = 0.0;
            foreach (Exit exit in _mainRepository.ExitRepository.GetExits())
            {
                if (exit.TimeOfExit >= _startDate && exit.TimeOfExit <= _stopDate)
                {
                    wholeIncome += exit.Price;
                    listBox1.Items.Add(exit.ToString());
                }
            }

            tbIncome.Text += wholeIncome;
        }

        private void InitListBox2()
        {
            double wholeIncome = 0.0;
            foreach (Exit exit in _mainRepository.ExitRepository.GetExits())
            {
                if ((exit.StationOfExit.Name==_stationsName) && (exit.TimeOfExit >= _startDate && exit.TimeOfExit <= _stopDate))
                {
                    wholeIncome += exit.Price;
                    listBox1.Items.Add(exit.ToString());
                }
            }
            tbIncome.Text += wholeIncome;
        }
    }
}