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
        EBARProcess ebarProcess = new EBARProcess();

        public ViewAnimeMenu()
        {
            InitializeComponent();
        }

        #region -- Mouse Click --
        private void btnLikeEmoji_Click(object sender, EventArgs e)
        {
            ViewAnime("LIKE");
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
        private void btnBack_Click(object sender, EventArgs e)
        {
            var adminMenu = new AdminMenu();
            adminMenu.Show();
            Hide();
        }
        private void btnRandomAnime_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ebarProcess.GetRandomAnimeFromAllEmojis(), "Random Anime Recommendation");
        }

        #endregion


        public void ViewAnime(string emoji)
        {

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
        #region-- Mouse Enter --
        private void btnLikeEmoji_MouseEnter(object sender, EventArgs e)
        {
            StretchButtonImage(btnLikeEmoji);

        }
        private void btnHeartEmoji_MouseEnter(object sender, EventArgs e)
        {
            StretchButtonImage(btnHeartEmoji);
        }
        private void btnLaughEmoji_MouseEnter(object sender, EventArgs e)
        {
            StretchButtonImage(btnLaughEmoji);
        }
        private void btnWowEmoji_MouseEnter(object sender, EventArgs e)
        {
            StretchButtonImage(btnWowEmoji);
        }
        private void btnSadEmoji_MouseEnter(object sender, EventArgs e)
        {
            StretchButtonImage(btnSadEmoji);
        }
        private void btnAngryEmoji_MouseEnter(object sender, EventArgs e)
        {
            StretchButtonImage(btnAngryEmoji);
        }
        private void btnRandomAnime_MouseEnter(object sender, EventArgs e)
        {
            StretchButtonImage(btnRandomAnime);
        }
        private void btnBack_MouseEnter(object sender, EventArgs e)
        {
            ChangeButtonColor(btnBack, Color.FromArgb(0, 86, 179), Color.White);
        }
        #endregion


        #region-- Mouse Leave --
        private void btnLikeEmoji_MouseLeave(object sender, EventArgs e)
        {

            ResetButtonImage(btnLikeEmoji);
        }
        private void btnHeartEmoji_MouseLeave(object sender, EventArgs e)
        {
            ResetButtonImage(btnHeartEmoji);
        }
        private void btnLaughEmoji_MouseLeave(object sender, EventArgs e)
        {
            ResetButtonImage(btnLaughEmoji);
        }
        private void btnWowEmoji_MouseLeave(object sender, EventArgs e)
        {
            ResetButtonImage(btnWowEmoji);
        }
        private void btnSadEmoji_MouseLeave(object sender, EventArgs e)
        {
            ResetButtonImage(btnSadEmoji);
        }
        private void btnAngryEmoji_MouseLeave(object sender, EventArgs e)
        {
            ResetButtonImage(btnAngryEmoji);
        }
        private void btnRandomAnime_MouseLeave(object sender, EventArgs e)
        {
            ResetButtonImage(btnRandomAnime);
        }
        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            ChangeButtonColorToDefault(btnBack, Color.White, Color.FromArgb(0, 86, 179));
        }
        #endregion

        public void StretchButtonImage(Button button)
        {
            button.BackgroundImageLayout = ImageLayout.Stretch;
        }
        public void ResetButtonImage(Button button)
        {
            button.BackgroundImageLayout = ImageLayout.Zoom;
        }

        public void ChangeButtonColor(Button button, Color backgroundColor, Color fontColor)
        {
            button.BackColor = backgroundColor;
            button.ForeColor = fontColor;
            button.FlatAppearance.BorderSize = 0;
        }
        public void ChangeButtonColorToDefault(Button button, Color backgroundColor, Color fontColor)
        {
            button.BackColor = backgroundColor;
            button.ForeColor = fontColor;
            button.FlatAppearance.BorderSize = 2;
        }



        
    }
}
