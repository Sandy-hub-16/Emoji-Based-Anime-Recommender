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
            //animeListDataService = new InMemoryDataService();
            //animeListDataService = new TextFileDataService();
            animeListDataService = new JsonFileDataService();
        }
        public void AddAnimeBasedOnEmoji(string emoji, string anime)
        {
            animeListDataService.AddAnimeBasedOnEmoji(emoji, anime);
        }

        public void RemoveAnimeBasedOnEmoji(string emoji, string anime)
        {
            animeListDataService.RemoveAnimeBasedOnEmoji(emoji,anime);
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
