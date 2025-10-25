using EBARCommon;
using EBARDataLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EBAR_BL
{
    public class EBARProcess 
    {
        AnimeListDataService animeListDataService = new AnimeListDataService();

        public bool ValidateEmptyInput(string userName)
        {
            if (string.IsNullOrWhiteSpace(userName))
            {
                return true;
            }
            return false;
        }

        public bool CheckReturntoMenu(string input)
        {
            if (input == "H")
            {
                Thread.Sleep(1000);
                return true;
            }
            return false;
        }

  

        public void AddAnimeBasedOnEmoji(string emoji, string anime)
        {
            animeListDataService.AddAnimeBasedOnEmoji(emoji, anime);
            EmailService email = new EmailService();
            email.SendEmail(anime, "added");
        }

        public void RemoveAnimeBasedOnEmoji(string emoji, string anime)
        {
            animeListDataService.RemoveAnimeBasedOnEmoji(emoji, anime);
            EmailService email = new EmailService();
            email.SendEmail(anime, "removed");
        }

        public List<string> ViewAnimeList(string emoji)
        {
            return animeListDataService.ViewAnimeList(emoji);

        }
        public string GetRandomAnimeFromAllEmojis()
        {
            return animeListDataService.GetRandomAnimeFromAllEmojis();

        }




    }
}
