using EBARDataLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace EBAR_BL
{
    public class EBARProcess : AnimeList
    {

        public bool ValidateEmptyInput(string userName)
        {
            if (string.IsNullOrWhiteSpace(userName))
            {
                return true;
            }
            return false;
        }

        public bool ValidateDuplicateInput(string animeInput) 
        {
            if (AnimeList.LikeEmoji.Contains(animeInput)||
                AnimeList.HeartEmoji.Contains(animeInput) ||
                AnimeList.LaughEmoji.Contains(animeInput) ||
                AnimeList.SadEmoji.Contains(animeInput) ||
                AnimeList.WowEmoji.Contains(animeInput) ||
                AnimeList.AngryEmoji.Contains(animeInput))
            {
                return true;
            }
           
            return false;
        }

      
        public void AddAnimeBasedOnEmoji(string emoji, string anime)
        {


                switch (emoji)
                {
                case "A": 
                    AnimeList.LikeEmoji.Add(anime); 
                    break;
                case "B": 
                    AnimeList.HeartEmoji.Add(anime); 
                    break;
                case "C": 
                    AnimeList.LaughEmoji.Add(anime); 
                    break;
                case "D": 
                    AnimeList.WowEmoji.Add(anime); 
                    break;
                case "E": 
                    AnimeList.SadEmoji.Add(anime); 
                    break;
                case "F": 
                    AnimeList.AngryEmoji.Add(anime); 
                    break;

                default: Console.WriteLine("Invalid Input"); break;
            }

            

        }

        public void RemoveAnimeBasedOnEmoji(string emoji, string anime)
        {
            

            switch (emoji)
            {
                case "A":
                    AnimeList.LikeEmoji.Remove(anime);
                    break;
                case "B":
                    AnimeList.HeartEmoji.Remove(anime);
                    break;
                case "C":
                    AnimeList.LaughEmoji.Remove(anime);
                    break;
                case "D":
                    AnimeList.WowEmoji.Remove(anime);
                    break;
                case "E":
                    AnimeList.SadEmoji.Remove(anime);
                    break;
                case "F":
                    AnimeList.AngryEmoji.Remove(anime);
                    break;
                default:
                    break;

                  
            }
            



        }

        public List<string> ViewAnimeList(string emoji) 
        {
            switch (emoji)
            {
                case "A": return new List<string>(AnimeList.LikeEmoji);
                    
                case "B": return new List<string>(AnimeList.HeartEmoji);

                case "C": return new List<string>(AnimeList.LaughEmoji);

                case "D": return new List<string>(AnimeList.WowEmoji);

                case "E": return new List<string>(AnimeList.SadEmoji);

                case "F": return new List<string>(AnimeList.AngryEmoji);

                default: return new List<string>();
                   
            }
        }







        public string GetRandomAnimeFromAllEmojis()
        {

            List<string> allAnime = new List<string>();
            allAnime.AddRange(AnimeList.LikeEmoji);
            allAnime.AddRange(AnimeList.HeartEmoji);
            allAnime.AddRange(AnimeList.LaughEmoji);
            allAnime.AddRange(AnimeList.WowEmoji);
            allAnime.AddRange(AnimeList.SadEmoji);
            allAnime.AddRange(AnimeList.AngryEmoji);

            Random randomAnime = new Random();

            int anime = randomAnime.Next(allAnime.Count); // get 1 random anime from allAnime list
            return allAnime[anime];
        }




    }
}
