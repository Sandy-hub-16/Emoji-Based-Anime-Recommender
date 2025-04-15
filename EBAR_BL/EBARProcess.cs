using EBARDataLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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

        public List<string> GetEmojiList(string emoji)
        {
            switch (emoji)
            {
                case "a": return EmojiList.likeEmojis;
                case "b": return EmojiList.heartEmojis;
                case "c": return EmojiList.laughEmojis;
                case "d": return EmojiList.wowEmojis;
                case "e": return EmojiList.sadEmojis;
                case "f": return EmojiList.angryEmojis;
                default: return null;
            }
        }


    

    public string GetRandomAnimeFromAllEmojis() //only get one random anime (temporary); still working on this
        {
     
            List<string> allAnime = new List<string>();
            allAnime.AddRange(EmojiList.likeEmojis);
            allAnime.AddRange(EmojiList.heartEmojis);
            allAnime.AddRange(EmojiList.laughEmojis);
            allAnime.AddRange(EmojiList.wowEmojis);
            allAnime.AddRange(EmojiList.sadEmojis);
            allAnime.AddRange(EmojiList.angryEmojis);

            Random randomAnime = new Random();

            int anime = randomAnime.Next(allAnime.Count);
            return allAnime[anime];
        }

        

       
    }
}
