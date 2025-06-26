using EBAR_BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EBAR_Desktop.User
{
    public partial class Login : Form
    {
        EBARProcess eBARProcess = new EBARProcess();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (eBARProcess.ValidateEmptyInput(txtUsername.Text))
            {
              MessageBox.Show("Textbox cannot be empty.Please enter a username.");
            }

            else
            {
                var userMenu = new Menu(txtUsername.Text);
                userMenu.Show();
                Hide();
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
