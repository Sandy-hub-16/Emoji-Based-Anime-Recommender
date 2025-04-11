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
        AdminActions adminActions = new AdminActions();


        public void SelectedEmoji()
        {
            while (true)
            {
                string adminInput = User.GetUserInput();
                if (adminInput == "a" ||
                   adminInput == "like".ToLower().Trim() ||
                   adminInput == "like emoji".ToLower().Trim())
                {
                    AddedLikeEmoji();

                }
                else if (adminInput == "b" ||
                   adminInput == "heart".ToLower().Trim() ||
                   adminInput == "heart emoji".ToLower().Trim())
                {
                    AddedHeartEmoji();

                }
                else if (adminInput == "c" ||
                   adminInput == "laugh".ToLower().Trim() ||
                   adminInput == "laugh emoji".ToLower().Trim())
                {
                    AddedLaughEmoji();

                }

                else if (adminInput == "d" ||
                   adminInput == "wow".ToLower().Trim() ||
                   adminInput == "wow emoji".ToLower().Trim())
                {
                    AddedWowEmoji();

                }
                else if (adminInput == "e" ||
                   adminInput == "sad".ToLower().Trim() ||
                   adminInput == "sad emoji".ToLower().Trim())
                {
                    AddedSadEmoji();

                }
                else if (adminInput == "f" ||
                   adminInput == "angry".ToLower().Trim() ||
                   adminInput == "angry emoji".ToLower().Trim())
                {

                    AddedAngryEmoji();
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }

                ReturnHome(adminInput);
            }



        }
        public void AddedLikeEmoji()
        {
            Console.Write("Add Anime : ");
            string animeAdd = Console.ReadLine().Trim();
            adminActions.addAnimeBasedOnEmoji(animeAdd, adminActions.likeEmojis);
        }   
        public void AddedHeartEmoji()
        {
            Console.Write("Add Anime : ");
            string animeAdd = Console.ReadLine().Trim();
            adminActions.addAnimeBasedOnEmoji(animeAdd, adminActions.heartEmojis);
        }
        public void AddedLaughEmoji()
        {
            Console.Write("Add Anime : ");
            string animeAdd = Console.ReadLine().Trim();
            adminActions.addAnimeBasedOnEmoji(animeAdd, adminActions.laughEmojis);
        }
        public void AddedWowEmoji()
        {
            Console.Write("Add Anime : ");
            string animeAdd = Console.ReadLine().Trim();
            adminActions.addAnimeBasedOnEmoji(animeAdd, adminActions.wowEmojis);
        }
        public void AddedSadEmoji()
        {
            Console.Write("Add Anime : ");
            string animeAdd = Console.ReadLine().Trim();
            adminActions.addAnimeBasedOnEmoji(animeAdd, adminActions.sadEmojis);
        }
        public void AddedAngryEmoji()
        {
            Console.Write("Add Anime : ");
            string animeAdd = Console.ReadLine().Trim();
            adminActions.addAnimeBasedOnEmoji(animeAdd, adminActions.angryEmojis);
        }
        public void ReturnHome(string adminInput)
        {

            if (adminInput.Equals("h".ToLower()) || adminInput == "home".ToLower().Trim())
            {
                Program.MainMenu();
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
                    Console.WriteLine("SELECT EMOJI : ");
                    User.DisplayEmoji();
                   
                    
                   
                    SelectedEmoji();
                    
                    break;
                }

                else if (adminInput.Equals("2") || adminInput == "delete")
                {
                    
                    adminActions.RemoveAnimeBasedOnEmoji(); // no function yet..
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
