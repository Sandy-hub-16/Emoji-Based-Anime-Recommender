using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EBAR_Desktop.User
{
    public partial class Menu : Form
    {
        ViewMenu.ViewAnimeMenu viewAnimeMenu = new ViewMenu.ViewAnimeMenu();
        public Menu(string username)
        {
            InitializeComponent();

            lblUsername.Text = $"{username}!";
        }

        private void btnLikeEmoji_Click(object sender, EventArgs e)
        {
            viewAnimeMenu.ViewAnime("LIKE");
        }

        private void btnHeartEmoji_Click(object sender, EventArgs e)
        {
            viewAnimeMenu.ViewAnime("HEART");
        }

        private void btnLaughEmoji_Click(object sender, EventArgs e)
        {
            viewAnimeMenu.ViewAnime("LAUGH");
        }

        private void btnWowEmoji_Click(object sender, EventArgs e)
        {
            viewAnimeMenu.ViewAnime("WOW");
        }

        private void btnSadEmoji_Click(object sender, EventArgs e)
        {
            viewAnimeMenu.ViewAnime("SAD");
        }

        private void btnAngryEmoji_Click(object sender, EventArgs e)
        {
            viewAnimeMenu.ViewAnime("ANGRY");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var mainMenu = new MainMenu();
            mainMenu.Show();
            Hide();
        }

       
    }
}
