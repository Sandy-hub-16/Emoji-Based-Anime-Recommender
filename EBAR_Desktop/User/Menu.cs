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

        #region-- Mouse Click --
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
        #endregion


        #region-- Mouse Enter --
        private void btnLikeEmoji_MouseEnter(object sender, EventArgs e)
        {
            viewAnimeMenu.StretchButtonImage(btnLikeEmoji);
        }
        private void btnHeartEmoji_MouseEnter(object sender, EventArgs e)
        {
            viewAnimeMenu.StretchButtonImage(btnHeartEmoji);
        }
        private void btnLaughEmoji_MouseEnter(object sender, EventArgs e)
        {
            viewAnimeMenu.StretchButtonImage(btnLaughEmoji);
        }
        private void btnWowEmoji_MouseEnter(object sender, EventArgs e)
        {
            viewAnimeMenu.StretchButtonImage(btnWowEmoji);
        }
        private void btnSadEmoji_MouseEnter(object sender, EventArgs e)
        {
            viewAnimeMenu.StretchButtonImage(btnSadEmoji);
        }
        private void btnAngryEmoji_MouseEnter(object sender, EventArgs e)
        {
            viewAnimeMenu.StretchButtonImage(btnAngryEmoji);
        }
        private void btnRandomAnime_MouseEnter(object sender, EventArgs e)
        {
            viewAnimeMenu.StretchButtonImage(btnRandomAnime);
        }
        #endregion

        #region-- Mouse Leave --
        private void btnLikeEmoji_MouseLeave(object sender, EventArgs e)
        {
            viewAnimeMenu.ResetButtonImage(btnLikeEmoji);
        }
        private void btnHeartEmoji_MouseLeave(object sender, EventArgs e)
        {
            viewAnimeMenu.ResetButtonImage(btnHeartEmoji);
        }
        private void btnLaughEmoji_MouseLeave(object sender, EventArgs e)
        {
            viewAnimeMenu.ResetButtonImage(btnLaughEmoji);
        }
        private void btnWowEmoji_MouseLeave(object sender, EventArgs e)
        {
            viewAnimeMenu.ResetButtonImage(btnWowEmoji);
        }
        private void btnSadEmoji_MouseLeave(object sender, EventArgs e)
        {
            viewAnimeMenu.ResetButtonImage(btnSadEmoji);
        }
        private void btnAngryEmoji_MouseLeave(object sender, EventArgs e)
        {
            viewAnimeMenu.ResetButtonImage(btnAngryEmoji);
        }
        private void btnRandomAnime_MouseLeave(object sender, EventArgs e)
        {
            viewAnimeMenu.ResetButtonImage(btnRandomAnime);
        }
        #endregion




        private void btnRandomAnime_Click(object sender, EventArgs e)
        {
            EBARProcess eBARProcess = new EBARProcess();
            MessageBox.Show(eBARProcess.GetRandomAnimeFromAllEmojis(), "Random Anime Recommendation");
        }



     
    }
}
