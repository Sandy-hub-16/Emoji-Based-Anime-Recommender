using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBAR_BL
{
    public class AdminActions
    {
        public List<string> likeEmojis = new List<string> { "One Piece", "Naruto", "DragonBall" };
        public List<string> heartEmojis = new List<string> { "Kimi Ni Todoke", "Kaguya-sama: Love Is War", "Fruits Basket" };
        public List<string> laughEmojis = new List<string> { "Mashle: Magic And Muscles", "Dandadan", "KonoSuba" };
        public List<string> wowEmojis = new List<string> { "Solo Leveling", "Frieren: Beyond Journey's End", "Jujutsu Kaisen" };
        public List<string> sadEmojis = new List<string> { "A Silent Voice", "Your Lie in April", "Anohana: The Flower We Saw That Day" };
        public List<string> angryEmojis = new List<string> { "Attack on Titan", "One Punch Man", "Vinland Saga" };

        public void addAnimeBasedOnEmoji(string anime, List<string> emojiType)
        {
            emojiType.Add(anime);
            Console.WriteLine($"{anime} added to the list.");
        }
        public void RemoveAnimeBasedOnEmoji()
        {
          
        }

       





    }
}
