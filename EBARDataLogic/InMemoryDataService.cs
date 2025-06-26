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
       public static readonly List<AnimeList> animeList = new List<AnimeList>(); 
        // made it public so that it can be accessed from the EBAR Desktop

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
            emoji = emoji.ToUpper().Trim();

            var list = animeList[0];

            if(emoji.StartsWith("LIKE") || emoji.Equals("A")) list.LikeEmoji.Add(anime);
            else if (emoji.StartsWith("HEART") || emoji.Equals("B")) list.HeartEmoji.Add(anime);
            else if (emoji.StartsWith("LAUGH") || emoji.Equals("C")) list.LaughEmoji.Add(anime);
            else if (emoji.StartsWith("WOW") || emoji.Equals("D")) list.WowEmoji.Add(anime);
            else if (emoji.StartsWith("SAD") || emoji.Equals("E")) list.SadEmoji.Add(anime);
            else if (emoji.StartsWith("ANGRY") || emoji.Equals("F")) list.AngryEmoji.Add(anime);
            else return; // Invalid emoji input, do nothing

        }
       
        public void RemoveAnimeBasedOnEmoji(string emoji, string anime)
        {
            emoji = emoji.ToUpper().Trim();
            var list = animeList[0];

            if(emoji.StartsWith("LIKE") || emoji.Equals("A")) list.LikeEmoji.Remove(anime);
            else if (emoji.StartsWith("HEART")|| emoji.Equals("B")) list.HeartEmoji.Remove(anime);
            else if (emoji.StartsWith("LAUGH") || emoji.Equals("C")) list.LaughEmoji.Remove(anime);
            else if (emoji.StartsWith("WOW") || emoji.Equals("D")) list.WowEmoji.Remove(anime);
            else if (emoji.StartsWith("SAD") || emoji.Equals("E")) list.SadEmoji.Remove(anime);
            else if (emoji.StartsWith("ANGRY") || emoji.Equals("F")) list.AngryEmoji.Remove(anime);
            else return; // Invalid emoji input, do nothing    
        }

        public List<string> ViewAnimeList(string emoji)
        {
            emoji = emoji.ToUpper().Trim();

            var list = animeList[0];

            if(emoji.StartsWith("LIKE") || emoji.Equals("A")) return list.LikeEmoji;
            else if (emoji.StartsWith("HEART") || emoji.Equals("B")) return list.HeartEmoji;
            else if (emoji.StartsWith("LAUGH") || emoji.Equals("C")) return list.LaughEmoji;
            else if (emoji.StartsWith("WOW") || emoji.Equals("D")) return list.WowEmoji;
            else if (emoji.StartsWith("SAD") || emoji.Equals("E")) return list.SadEmoji;
            else if (emoji.StartsWith("ANGRY") || emoji.Equals("F")) return list.AngryEmoji;
            else return new List<string>(); // Invalid emoji input, return empty list

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
