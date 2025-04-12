using EBAR_BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emoji_Based_Anime_Recommender
{
    public class Admin 
    {
       


        public void AddSelectedEmoji()
        {
            while (true)
            {
                string adminInput = User.GetUserInput();
                if (adminInput == "a" ||
                   adminInput == "like".ToLower().Trim() ||
                   adminInput == "like emoji".ToLower().Trim())
                {
                    AddAnimeToEmojiListInterface(AdminActions.likeEmojis);
                    ReturnHome();

                }
                else if (adminInput == "b" ||
                   adminInput == "heart".ToLower().Trim() ||
                   adminInput == "heart emoji".ToLower().Trim())
                {
                    AddAnimeToEmojiListInterface(AdminActions.heartEmojis);
                    ReturnHome();

                }
                else if (adminInput == "c" ||
                   adminInput == "laugh".ToLower().Trim() ||
                   adminInput == "laugh emoji".ToLower().Trim())
                {
                    AddAnimeToEmojiListInterface(AdminActions.laughEmojis);
                    ReturnHome();

                }

                else if (adminInput == "d" ||
                   adminInput == "wow".ToLower().Trim() ||
                   adminInput == "wow emoji".ToLower().Trim())
                {
                    AddAnimeToEmojiListInterface(AdminActions.wowEmojis);
                    ReturnHome();

                }
                else if (adminInput == "e" ||
                   adminInput == "sad".ToLower().Trim() ||
                   adminInput == "sad emoji".ToLower().Trim())
                {
                    AddAnimeToEmojiListInterface(AdminActions.sadEmojis);
                    ReturnHome();

                }
                else if (adminInput == "f" ||
                   adminInput == "angry".ToLower().Trim() ||
                   adminInput == "angry emoji".ToLower().Trim())
                {

                    AddAnimeToEmojiListInterface(AdminActions.angryEmojis);
                    ReturnHome();
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }

                
            }



        }

        #region -- Adding Anime Series Based on Emoji Types (Function) --

        public void AddAnimeToEmojiListInterface(List<string> emojiList)
        {
            Console.Write("Add Anime : ");
            string animeAdd = Console.ReadLine().Trim();
            AdminActions.addAnimeBasedOnEmoji(animeAdd, emojiList);

        }
        #endregion

       

        public void ReturnHome()
        {
            Console.Write("Type [H] to return Home OR Type any key to add another : ");
            string input = Console.ReadLine().ToLower().Trim();

            if (input == "h" || input == "home")
            {
                Program.MainMenu();
            }
            else
            {
                AddSelectedEmoji();
            }
        }

        public void ShowAdminMenu()
        {
            string[] updateAnimeSeriesList = {"[1]Add", "[2]Delete","[H]HOME","[X]EXIT"};

            

            while (true)
            {
                Console.WriteLine("ADMIN MENU :");
                foreach (var updateList in updateAnimeSeriesList)
                {
                    Console.WriteLine(updateList);
                }
                string adminInput = User.GetUserInput();

                if (adminInput.Equals("1") || adminInput == "add")
                {
                    Console.WriteLine("SELECT EMOJI to ADD on the list : ");
                    User.DisplayEmoji();
                   
                    
                   
                    AddSelectedEmoji();
                    
                    break;
                }

                else if (adminInput.Equals("2") || adminInput == "delete")
                {
                    Console.WriteLine("SELECT EMOJI to DELETE on the list: ");
                    User.DisplayEmoji();

                    User.GetUserInput();

                    break;
                }

                else if (adminInput.Equals("h".ToLower())|| adminInput == "home".ToLower().Trim()) 
                {
                    Program.MainMenu();
                    break;
                }
                else if (adminInput == "x".ToLower().Trim() || adminInput == "exit".ToLower().Trim()) 
                {
                    Console.WriteLine("Bye Admin! <3");
                    break;
                }
                else if (string.IsNullOrWhiteSpace(adminInput))
                {
                    Console.WriteLine("Input cannot be empty");
                }
                else
                {
                    Console.WriteLine("Enter existing choices only");
                }
            }
        }
      






    }
}
