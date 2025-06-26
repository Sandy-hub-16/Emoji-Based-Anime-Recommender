using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EBAR_Desktop
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;

            if (username.Equals("sandy") && password.Equals("12345"))
            {
                MessageBox.Show("Login Successfully..");
                var adminMenu = new AdminMenu();
                adminMenu.Show();
                Hide();
            }

            else
            {
                MessageBox.Show("Invalid Username or Password..");


            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var mainMenu = new MainMenu();
            mainMenu.Show();
            Hide();
        }
    }
}
