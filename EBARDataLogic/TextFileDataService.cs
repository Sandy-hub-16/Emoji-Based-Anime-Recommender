using EBARCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBARDataLogic
{
    public class TextFileDataService : IAnimeListDataService
    {
        string filePath = "emojis.txt";

        private static readonly List<AnimeList> animeList = new List<AnimeList>();



        public TextFileDataService()
        {
            GetDataFromFile();
        }

        private void GetDataFromFile()
        {
            var lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                var parts = line.Split('|');

                animeList.Add(new AnimeList
                {
                    LikeEmoji = parts[0].Split(',',StringSplitOptions.RemoveEmptyEntries).ToList(),
                    HeartEmoji = parts[1].Split(',',StringSplitOptions.RemoveEmptyEntries).ToList(),
                    WowEmoji = parts[2].Split(',', StringSplitOptions.RemoveEmptyEntries).ToList(),
                    LaughEmoji = parts[3].Split(',', StringSplitOptions.RemoveEmptyEntries).ToList(),
                    SadEmoji = parts[4].Split(',', StringSplitOptions.RemoveEmptyEntries).ToList(),
                    AngryEmoji = parts[5].Split(',', StringSplitOptions.RemoveEmptyEntries).ToList()
                });

            }
        }

        private void WriteDataToFile()
        {
            var lines = new List<string>(); 

            for (int i = 0; i < animeList.Count; i++)
            {
                lines.Add(string.Join(",", animeList[i].LikeEmoji) + "|" +
                          string.Join(",", animeList[i].HeartEmoji) + "|" +
                          string.Join(",", animeList[i].WowEmoji) + "|" +
                          string.Join(",", animeList[i].LaughEmoji) + "|" +
                          string.Join(",", animeList[i].SadEmoji) + "|" +
                          string.Join(",", animeList[i].AngryEmoji));
            }

            File.WriteAllLines(filePath, lines);
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

            WriteDataToFile();
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

            WriteDataToFile();
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
