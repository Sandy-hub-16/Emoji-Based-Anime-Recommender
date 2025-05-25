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
            adminLogin.ShowDialog();


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
