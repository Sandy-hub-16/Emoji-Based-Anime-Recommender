using EBARCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBARDataLogic
{
    public class InMemoryDataService : IAnimeListDataService
    {
       private static readonly List<AnimeList> animeList = new List<AnimeList>(); 
        // readonly -> once assigned, its value cannot be changed
        /*
         ex.
            animeList.Add("Sandy"); == assigned (valid)

            animeList.Add("Napiza"); == assigned again(invalid)
         */
      
        public InMemoryDataService()
        {
            CreateDefaultAnimeList();
        }

       

        public void CreateDefaultAnimeList()
        {
            animeList.Add(new AnimeList
            {
                LikeEmoji = new List<string> { "NARUTO", "ONE PIECE", "DRAGONBALL" },
                HeartEmoji = new List<string> { "KIMI NI TODOKE", "KAGUYA-SAMA: LOVE IS WAR", "FRUITS BASKET" },
                WowEmoji = new List<string> { "SOLO LEVELING", "FRIEREN: BEYOND JOURNEY'S END", "JUJUTSU KAISEN" },
                LaughEmoji = new List<string> { "MASHLE: MAGIC AND MUSCLES", "DANDADAN", "KONOSUBA" },
                SadEmoji = new List<string> { "A SILENT VOICE", "YOUR LIE IN APRIL", "ANOHANA: THE FLOWER WE SAW THAT DAY" },
                AngryEmoji = new List<string> { "ATTACK ON TITAN", "ONE PUNCH MAN", "VINLAND SAGA" }


            });

        }
        public void AddAnimeBasedOnEmoji(string emoji, string anime)
        {
            var list = animeList[0];
            switch (emoji)
                {
                    case "A": list.LikeEmoji.Add(anime); break;
                    case "B": list.HeartEmoji.Add(anime); break;
                    case "C": list.LaughEmoji.Add(anime); break;
                    case "D": list.WowEmoji.Add(anime); break;
                    case "E": list.SadEmoji.Add(anime); break;
                    case "F": list.AngryEmoji.Add(anime); break;
                    default: return;

                } 
        }
       
        public void RemoveAnimeBasedOnEmoji(string emoji, string anime)
        {
            var list = animeList[0];

            switch (emoji)
                {
                case "A": list.LikeEmoji.Remove(anime); break;
                case "B": list.HeartEmoji.Remove(anime); break;
                case "C": list.LaughEmoji.Remove(anime); break;
                case "D": list.WowEmoji.Remove(anime); break;
                case "E": list.SadEmoji.Remove(anime); break;
                case "F": list.AngryEmoji.Remove(anime); break;
                default: return;
            }      
        }

        public List<string> ViewAnimeList(string emoji)
        {
            var list = animeList[0];
                switch (emoji)
                {
                    case "A": return new List<string>(list.LikeEmoji);
                    case "B": return new List<string>(list.HeartEmoji);
                    case "C": return new List<string>(list.LaughEmoji);
                    case "D": return new List<string>(list.WowEmoji);
                    case "E": return new List<string>(list.SadEmoji);
                    case "F": return new List<string>(list.AngryEmoji);
                    default: return new List<string>();
                }
            
        }
        public string GetRandomAnimeFromAllEmojis()
        {
            var list = animeList[0];

            List<string> allAnime = new List<string>();
            allAnime.AddRange(list.LikeEmoji);
            allAnime.AddRange(list.HeartEmoji);
            allAnime.AddRange(list.LaughEmoji);
            allAnime.AddRange(list.WowEmoji);
            allAnime.AddRange(list.SadEmoji);
            allAnime.AddRange(list.AngryEmoji);


            Random randomAnime = new Random();
            int anime = randomAnime.Next(allAnime.Count);
            return allAnime[anime];

        }

    }
}
