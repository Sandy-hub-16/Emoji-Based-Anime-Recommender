using EBAR_BL;
using EBAR_Desktop.ViewMenu;
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

namespace EBAR_Desktop.AddMenu
{
    public partial class SadEmoji : Form
    {
        EBARProcess eBARProcess = new EBARProcess();
        ViewAnimeMenu buttonEffect = new ViewAnimeMenu();
        public SadEmoji()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string animeInput = txtInput.Text.Trim().ToUpper();
            if (InMemoryDataService.animeList[0].SadEmoji.Contains(animeInput))
            {
                MessageBox.Show($"Anime : {animeInput} already exists...");
                txtInput.Clear();
            }

            else if (InMemoryDataService.animeList.Count > 0 && !string.IsNullOrEmpty(animeInput))
            {
                eBARProcess.AddAnimeBasedOnEmoji("SAD", animeInput);
                MessageBox.Show($"Anime : {animeInput} added in Sad Emoji List.");
                txtInput.Clear();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var addMenu = new AddAnimeMenu();
            addMenu.Show();
            Hide();
        }

        #region--Mouse Enter--
        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            buttonEffect.ChangeButtonColor(btnAdd, Color.LimeGreen, Color.White);
        }
        private void btnBack_MouseEnter(object sender, EventArgs e)
        {
            buttonEffect.ChangeButtonColor(btnBack, Color.FromArgb(0, 86, 179), Color.White);
        }
        #endregion

        #region--Mouse Leave--
        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            buttonEffect.ChangeButtonColorToDefault(btnAdd, Color.White, Color.LimeGreen);
        }
        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            buttonEffect.ChangeButtonColorToDefault(btnBack, Color.White, Color.FromArgb(0, 86, 179));
        }
        #endregion
    }
}
