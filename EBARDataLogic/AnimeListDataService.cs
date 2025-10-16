using EBARCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBARDataLogic
{
    public class AnimeListDataService
    {
        IAnimeListDataService animeListDataService;

        public AnimeListDataService()
        {
            animeListDataService = new InMemoryDataService();
            //animeListDataService = new TextFileDataService();
            //animeListDataService = new JsonFileDataService();
            //animeListDataService = new DBDataService();
        }


        public void AddAnimeBasedOnEmoji(string emoji, string anime)
        {
            animeListDataService.AddAnimeBasedOnEmoji(emoji, anime);
            EmailService email = new EmailService();
            email.SendEmail(anime, "added");
        }

        public void RemoveAnimeBasedOnEmoji(string emoji, string anime)
        {
            animeListDataService.RemoveAnimeBasedOnEmoji(emoji,anime);
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
