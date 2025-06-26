using EBAR_BL;
using EBARDataLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EBAR_Desktop.ViewMenu
{
    public partial class ViewAnimeMenu : Form
    {

        public ViewAnimeMenu()
        {
            InitializeComponent();
        }

        private void btnLikeEmoji_Click(object sender, EventArgs e)
        {
            ViewAnime("LIKE");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var adminMenu = new AdminMenu();
            adminMenu.Show();
            Hide();
        }
       

        private void btnHeartEmoji_Click(object sender, EventArgs e)
        {
            ViewAnime("HEART");
        }

        private void btnLaughEmoji_Click(object sender, EventArgs e)
        {
            ViewAnime("LAUGH");
        }

        private void btnWowEmoji_Click(object sender, EventArgs e)
        {
            ViewAnime("WOW");
        }

        private void btnSadEmoji_Click(object sender, EventArgs e)
        {
            ViewAnime("SAD");
        }

        private void btnAngryEmoji_Click(object sender, EventArgs e)
        {
            ViewAnime("ANGRY");
        }

        public void ViewAnime(string emoji)
        {
            var ebarProcess = new EBARProcess();
            List<string> animeList = ebarProcess.ViewAnimeList(emoji);
            if (animeList.Count == 0)
            {
                MessageBox.Show("No anime data available. Please add anime first.");
            }

            else
            {
                MessageBox.Show(string.Join(", ", animeList), $" {emoji} Emoji Anime Recommendation");
            }

             
        }
    }
}
