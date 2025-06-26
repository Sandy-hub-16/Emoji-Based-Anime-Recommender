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
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

     

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addMenu = new AddMenu.AddAnimeMenu();
            addMenu.Show();
            Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var deleteMenu = new DeleteMenu.DeleteAnimeMenu();
            deleteMenu.Show();
            Hide();
        }
        private void btnView_Click(object sender, EventArgs e)
        {
            var viewMenu = new ViewMenu.ViewAnimeMenu();
            viewMenu.Show();
            Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", buttons);
            if (result == DialogResult.Yes) {
                var mainMenu = new MainMenu();
                mainMenu.Show();
                Hide();
            }
            
        }
    }
}
