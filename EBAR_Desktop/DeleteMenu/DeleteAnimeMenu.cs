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
        public DeleteAnimeMenu()
        {
            InitializeComponent();
        }

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
    }
}
