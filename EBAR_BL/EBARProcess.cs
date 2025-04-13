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



        public void AddAnimeToEmojiListInterface(List<string> emojiList)
        {
            Console.Write("Add Anime : ");
            string animeAdd = Console.ReadLine().Trim();
            Console.WriteLine(EmojiList.AddAnimeBasedOnEmoji(animeAdd, emojiList));

        }


        public void SelectedEmojiToAdd()
        {

            while (true)
            {
                Console.Write("Enter Emoji to Add : ");
                string adminInput = Console.ReadLine();
                if (adminInput == "a" || adminInput == "like" || adminInput == "like emoji")
                    AddAnimeToEmojiListInterface(EmojiList.likeEmojis);

                else if (adminInput == "b" || adminInput == "heart" || adminInput == "heart emoji")
                    AddAnimeToEmojiListInterface(EmojiList.heartEmojis);

                else if (adminInput == "c" || adminInput == "laugh" || adminInput == "laugh emoji")
                    AddAnimeToEmojiListInterface(EmojiList.laughEmojis);

                else if (adminInput == "d" || adminInput == "wow" || adminInput == "wow emoji")
                    AddAnimeToEmojiListInterface(EmojiList.wowEmojis);

                else if (adminInput == "e" || adminInput == "sad" || adminInput == "sad emoji")
                    AddAnimeToEmojiListInterface(EmojiList.sadEmojis);

                else if (adminInput == "f" || adminInput == "angry" || adminInput == "angry emoji")
                    AddAnimeToEmojiListInterface(EmojiList.angryEmojis);

                else
                {
                    Console.WriteLine("Invalid Input");
                }
                Console.Write("Type [H] to return Home OR Type any key to add another : ");
                string input = Console.ReadLine();

                if (input == "h" || input == "home")
                {
                    return;
                }


            }



        }

        public void RemoveAnimeToEmojiList()
        {
            while (true)
            {
                
                string adminInput = Console.ReadLine();
                List<string> selectedEmojiList = null;

                if (adminInput == "a" || adminInput == "like" || adminInput == "like emoji")
                    selectedEmojiList = EmojiList.likeEmojis;

                else if (adminInput == "b" || adminInput == "heart" || adminInput == "heart emoji")
                    selectedEmojiList = EmojiList.heartEmojis;

                else if (adminInput == "c" || adminInput == "laugh" || adminInput == "laugh emoji")
                    selectedEmojiList = EmojiList.laughEmojis;

                else if (adminInput == "d" || adminInput == "wow" || adminInput == "wow emoji")
                    selectedEmojiList = EmojiList.wowEmojis;

                else if (adminInput == "e" || adminInput == "sad" || adminInput == "sad emoji")
                    selectedEmojiList = EmojiList.sadEmojis;

                else if (adminInput == "f" || adminInput == "angry" || adminInput == "angry emoji")
                    selectedEmojiList = EmojiList.angryEmojis;

                else
                {
                    Console.WriteLine("Invalid Input");
                }

                foreach (var animeList in selectedEmojiList)
                {
                    Console.WriteLine(animeList);
                }
                Console.WriteLine("Remove Anime : ");
                string animeRemove = Console.ReadLine();
                Console.WriteLine(EmojiList.RemoveAnimeBasedOnEmoji(animeRemove, selectedEmojiList));

                Console.Write("Type [H] to return HOME or type any key to delete another anime : ");
                string continueInput = Console.ReadLine();

                if (continueInput == "h")
                {
                    return;
                }
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
