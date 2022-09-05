using System;
using System.Windows.Forms;
using SIMS.Controller;
using SIMS.Model;
using SIMS.Repository;

namespace SIMS.View
{
    public partial class ChangePasswordWindow : Form
    {
        private UsersController _usersController;
        private User _user;
        public ChangePasswordWindow(User user, UsersController usersController)
        {
            _usersController = usersController;
            _user = user;
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            _usersController.ChangePassword(_user.Email, tbNewPass.Text);
            MessageBox.Show(@"You have successfully changed your password!");
            this.Hide();
        }
    }
}