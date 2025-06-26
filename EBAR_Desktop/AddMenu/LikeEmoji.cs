using EBAR_BL;
using EBARCommon;
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
    
    public partial class LikeEmoji : Form
    {
        EBARProcess eBARProcess = new EBARProcess();
        

        public LikeEmoji()
        {
            InitializeComponent();

        }

        


        private void btnAdd_Click(object sender, EventArgs e)
        {
            string animeInput = txtInput.Text.Trim().ToUpper();
            if (InMemoryDataService.animeList[0].LikeEmoji.Contains(animeInput))
            {
                MessageBox.Show($"Anime : {animeInput} already exists...");
                txtInput.Clear();
            }

            else if(InMemoryDataService.animeList.Count > 0 && !string.IsNullOrEmpty(animeInput))
            {
                eBARProcess.AddAnimeBasedOnEmoji("LIKE", animeInput);
                MessageBox.Show($"Anime : {animeInput} added in Like Emoji List.");
                txtInput.Clear();
            }



        }




        private void btnBack_Click(object sender, EventArgs e)
        {
            var addMenu = new AddAnimeMenu();
            addMenu.Show();
            Hide();
        }
    }
}
