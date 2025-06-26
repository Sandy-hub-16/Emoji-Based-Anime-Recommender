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

namespace EBAR_Desktop.DeleteMenu
{
    public partial class LikeEmoji : Form
    {
        EBARProcess eBARProcess = new EBARProcess();
        public LikeEmoji()
        {
            InitializeComponent();
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            
            string animeInput = txtInput.Text.Trim().ToUpper();
            if (InMemoryDataService.animeList[0].LikeEmoji.Contains(animeInput))
            {
                eBARProcess.RemoveAnimeBasedOnEmoji("LIKE", animeInput);
                MessageBox.Show($"Anime : {animeInput} has been removed from 👍 Emoji List.");
                txtInput.Clear();
            
            }
            else
            {
                MessageBox.Show($"Anime : {animeInput} does not exist in 👍 Emoji List.");
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var deleteAnimeMenu = new DeleteAnimeMenu();
            deleteAnimeMenu.Show();
            Hide();
        }
    }
}
