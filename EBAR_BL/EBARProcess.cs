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

        public bool ValidateEmptyUserName(string userName)
        {
            if (string.IsNullOrWhiteSpace(userName))
            {
                return true;
            }
            return false;
        }

        public bool ValidateDuplicateInput(string animeInput) 
        {
            if (EmojiList.LikeEmoji.Contains(animeInput)||
                EmojiList.HeartEmoji.Contains(animeInput) ||
                EmojiList.LaughEmoji.Contains(animeInput) ||
                EmojiList.SadEmoji.Contains(animeInput) ||
                EmojiList.WowEmoji.Contains(animeInput) ||
                EmojiList.AngryEmoji.Contains(animeInput))
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
                    EmojiList.LikeEmoji.Add(anime); 
                    break;
                case "B": 
                    EmojiList.HeartEmoji.Add(anime); 
                    break;
                case "C": 
                    EmojiList.LaughEmoji.Add(anime); 
                    break;
                case "D": 
                    EmojiList.WowEmoji.Add(anime); 
                    break;
                case "E": 
                    EmojiList.SadEmoji.Add(anime); 
                    break;
                case "F": 
                    EmojiList.AngryEmoji.Add(anime); 
                    break;

                default: Console.WriteLine("Invalid Input"); break;
            }

            

        }

        public void RemoveAnimeBasedOnEmoji(string emoji, string anime)
        {
            

            switch (emoji)
            {
                case "A":
                    EmojiList.LikeEmoji.Remove(anime);
                    break;
                case "B":
                    EmojiList.HeartEmoji.Remove(anime);
                    break;
                case "C":
                    EmojiList.LaughEmoji.Remove(anime);
                    break;
                case "D":
                    EmojiList.WowEmoji.Remove(anime);
                    break;
                case "E":
                    EmojiList.SadEmoji.Remove(anime);
                    break;
                case "F":
                    EmojiList.AngryEmoji.Remove(anime);
                    break;
                default:
                    break;

                  
            }
            



        }

        public List<string> ViewAnimeList(string emoji) 
        {
            switch (emoji)
            {
                case "A": return new List<string>(EmojiList.LikeEmoji);
                    
                case "B": return new List<string>(EmojiList.HeartEmoji);

                case "C": return new List<string>(EmojiList.LaughEmoji);

                case "D": return new List<string>(EmojiList.WowEmoji);

                case "E": return new List<string>(EmojiList.SadEmoji);

                case "F": return new List<string>(EmojiList.AngryEmoji);

                default: return new List<string>();
                   
            }
        }







        public string GetRandomAnimeFromAllEmojis()
        {

            List<string> allAnime = new List<string>();
            allAnime.AddRange(EmojiList.LikeEmoji);
            allAnime.AddRange(EmojiList.HeartEmoji);
            allAnime.AddRange(EmojiList.LaughEmoji);
            allAnime.AddRange(EmojiList.WowEmoji);
            allAnime.AddRange(EmojiList.SadEmoji);
            allAnime.AddRange(EmojiList.AngryEmoji);

            Random randomAnime = new Random();

            int anime = randomAnime.Next(allAnime.Count); // get I random anime from allAnime list
            return allAnime[anime];
        }




    }
}
