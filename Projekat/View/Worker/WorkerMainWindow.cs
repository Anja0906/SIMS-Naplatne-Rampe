using System;
using System.Windows.Forms;
using SIMS.Controller;
using SIMS.Model;
using SIMS.Repository;

namespace SIMS.View
{
    public partial class WorkerMainWindow : Form
    {
        private WorkersController _workersController;
        private Worker _worker;
        private MainRepository _mainRepository;
        public WorkerMainWindow(Worker worker, WorkersController workersController, MainRepository mainRepository)
        {
            _workersController = workersController;
            _worker = worker;
            _mainRepository = mainRepository;
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            _workersController.Save();
            this.Hide();
            LogInWindow logInWindow = new LogInWindow();
            logInWindow.Show();
        }

        private void btnCollect_Click(object sender, EventArgs e)
        {
            _workersController.InitQueue();
            Entry entry = _mainRepository.EntryRepository.Dequeue();
            TollCollectingWindow tollCollectingWindow = new TollCollectingWindow(_mainRepository, entry, _worker.Station, new ExitController(_mainRepository));
            tollCollectingWindow.Show();
        }

        private void btnInform_Click(object sender, EventArgs e)
        {
            InformThePoliceWindow informThePoliceWindow = new InformThePoliceWindow();
            informThePoliceWindow.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChangePasswordWindow changePasswordWindow =
                new ChangePasswordWindow(_worker, new UsersController(_mainRepository));
            changePasswordWindow.Show();
        }
        
    }
}