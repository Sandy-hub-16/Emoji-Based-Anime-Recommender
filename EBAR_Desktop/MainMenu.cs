namespace EBAR_Desktop
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            var adminLogin = new AdminLogin();
            adminLogin.Show();
            Hide();


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Logout Confirmation", buttons);
            if (result == DialogResult.Yes)
            {
                Dispose();
            }
           
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            var userLogin = new User.Login();
            userLogin.Show();
            Hide();
        }
    }
}
