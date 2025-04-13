using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBARDataLogic
{
    // class made static >> kasi pag iniinstantiate sa ibang class narireset ung list (nabalik sa default na list) ->
    //                   >> d nauupdate yung list
    public static class EmojiList
    {
        public static List<string> likeEmojis = new List<string> { "One Piece", "Naruto", "DragonBall" };
        public static List<string> heartEmojis = new List<string> { "Kimi Ni Todoke", "Kaguya-sama: Love Is War", "Fruits Basket" };
        public static List<string> laughEmojis = new List<string> { "Mashle: Magic And Muscles", "Dandadan", "KonoSuba" };
        public static List<string> wowEmojis = new List<string> { "Solo Leveling", "Frieren: Beyond Journey's End", "Jujutsu Kaisen" };
        public static List<string> sadEmojis = new List<string> { "A Silent Voice", "Your Lie in April", "Anohana: The Flower We Saw That Day" };
        public static List<string> angryEmojis = new List<string> { "Attack on Titan", "One Punch Man", "Vinland Saga" };

        public static string AddAnimeBasedOnEmoji(string anime, List<string> emojiType)
        {
            if (string.IsNullOrEmpty(anime))
            {
                return "Input cannot be empty...";
            }
            

            emojiType.Add(anime);
            UpdatedAnimeList(emojiType);
            return $"{anime} added to the list.";
                
            


        }

        public static string RemoveAnimeBasedOnEmoji(string anime, List<string> emojiList)
        {
            if (string.IsNullOrEmpty(anime))
            {
                return "Input cannot be empty...";
            }

            else if (emojiList.Contains(anime))
            {
                emojiList.Remove(anime);
                UpdatedAnimeList(emojiList);
                return $"Anime : {anime} has been removed to the list";
                
            }

            
                return $"Anime : {anime} doesn't exist from the list";
            


        }

        public static void UpdatedAnimeList(List<string> emojiType)
        {
            Console.WriteLine($"UPDATE LIST:");
            foreach (var anime in emojiType)
            {
                Console.WriteLine(anime);
            }
        }
    }
}
