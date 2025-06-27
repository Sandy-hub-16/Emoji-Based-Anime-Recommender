using EBAR_Desktop.ViewMenu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EBAR_Desktop.DeleteMenu
{
    public partial class DeleteAnimeMenu : Form
    {
        ViewAnimeMenu buttonEffect = new ViewAnimeMenu();
        public DeleteAnimeMenu()
        {
            InitializeComponent();
        }

        #region-- Mouse Click --
        private void btnLikeEmoji_Click(object sender, EventArgs e)
        {
            var likeEmoji = new LikeEmoji();
            likeEmoji.Show();
            Hide();
        }
        private void btnHeartEmoji_Click(object sender, EventArgs e)
        {
            var heartEmoji = new HeartEmoji();
            heartEmoji.Show();
            Hide();
        }
        private void btnLaughEmoji_Click(object sender, EventArgs e)
        {
            var laughEmoji = new LaughEmoji();
            laughEmoji.Show();
            Hide();
        }
        private void btnWowEmoji_Click(object sender, EventArgs e)
        {
            var wowEmoji = new WowEmoji();
            wowEmoji.Show();
            Hide();
        }
        private void btnSadEmoji_Click(object sender, EventArgs e)
        {
            var sadEmoji = new SadEmoji();
            sadEmoji.Show();
            Hide();
        }
        private void btnAngryEmoji_Click(object sender, EventArgs e)
        {
            var angryEmoji = new AngryEmoji();
            angryEmoji.Show();
            Hide();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            var adminMenu = new AdminMenu();
            adminMenu.Show();
            Hide();
        }
        #endregion

        #region--Mouse Enter --
        private void btnLikeEmoji_MouseEnter(object sender, EventArgs e)
        {
            buttonEffect.StretchButtonImage(btnLikeEmoji);
        }
        private void btnHeartEmoji_MouseEnter(object sender, EventArgs e)
        {
            buttonEffect.StretchButtonImage(btnHeartEmoji);
        }
        private void btnLaughEmoji_MouseEnter(object sender, EventArgs e)
        {
            buttonEffect.StretchButtonImage(btnLaughEmoji);
        }
        private void btnWowEmoji_MouseEnter(object sender, EventArgs e)
        {
            buttonEffect.StretchButtonImage(btnWowEmoji);
        }
        private void btnSadEmoji_MouseEnter(object sender, EventArgs e)
        {
            buttonEffect.StretchButtonImage(btnSadEmoji);
        }
        private void btnAngryEmoji_MouseEnter(object sender, EventArgs e)
        {
            buttonEffect.StretchButtonImage(btnAngryEmoji);
        }
        private void btnBack_MouseEnter(object sender, EventArgs e)
        {
            buttonEffect.ChangeButtonColor(btnBack, Color.FromArgb(0, 86, 179), Color.White);
        }
        #endregion

        #region--Mouse Leave --
        private void btnLikeEmoji_MouseLeave(object sender, EventArgs e)
        {
            buttonEffect.ResetButtonImage(btnLikeEmoji);
        }
        private void btnHeartEmoji_MouseLeave(object sender, EventArgs e)
        {
            buttonEffect.ResetButtonImage(btnHeartEmoji);
        }
        private void btnLaughEmoji_MouseLeave(object sender, EventArgs e)
        {
            buttonEffect.ResetButtonImage(btnLaughEmoji);
        }
        private void btnWowEmoji_MouseLeave(object sender, EventArgs e)
        {
            buttonEffect.ResetButtonImage(btnWowEmoji);
        }
        private void btnSadEmoji_MouseLeave(object sender, EventArgs e)
        {
            buttonEffect.ResetButtonImage(btnSadEmoji);
        }
        private void btnAngryEmoji_MouseLeave(object sender, EventArgs e)
        {
            buttonEffect.ResetButtonImage(btnAngryEmoji);
        }
        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            buttonEffect.ChangeButtonColorToDefault(btnBack, Color.White, Color.FromArgb(0, 86, 179));
        }
        #endregion





    }
}
