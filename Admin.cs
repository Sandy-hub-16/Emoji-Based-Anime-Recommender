using EBAR_BL;
using EBARDataLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emoji_Based_Anime_Recommender
{
    public class Admin 
    {


        public void ShowAdminMenu()
        {
            string[] updateAnimeSeriesList = {"[1]Add", "[2]Delete", "[3]View Anime List", "[H]HOME","[X]EXIT"};

            

            while (true)
            {
                Console.WriteLine("ADMIN MENU :");
                foreach (var updateList in updateAnimeSeriesList)
                {
                    Console.WriteLine(updateList);
                }
                string adminInput = User.GetInput("Choose Options : ");

                if (adminInput.Equals("1") || adminInput == "add")
                {
                    Console.WriteLine("SELECT EMOJI to ADD on the list : ");
                    User.DisplayEmoji();
                   
                                              
                    SelectedEmojiToAdd();
                    
               
                }

                else if (adminInput.Equals("2") || adminInput == "delete")
                {
                    Console.WriteLine("SELECT EMOJI to DELETE on the list: ");
                    User.DisplayEmoji();



                    SelectedEmojiToRemove();

                    break;
                }
                else if (adminInput.Equals("3") || adminInput == "view anime list")
                {
                    //UpdatedAnimeList();

                    break;
                }

                else if (adminInput.Equals("h")|| adminInput == "home") 
                {
                    return; // uses return >> babalik sa MainMenu() or babalik sa previous method na nagcall kay ShowAdminMenu()

                }
                else if (adminInput == "x" || adminInput == "exit") 
                {
                    Console.WriteLine("Bye Admin! <3");
                    Environment.Exit(0);
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

        public void UpdatedAnimeList(List<string> emojiType)
        {
            Console.WriteLine($"UPDATE LIST:");
            foreach (var anime in emojiType)
            {
                Console.WriteLine(anime);
            }
        }

        #region -- Add Function --

        public void SelectedEmojiToAdd()
        {

            while (true)
            {
                string adminInput = User.GetInput("Enter Emoji to Add : ");
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
            
                string input = User.GetInput("Type [B] to go back to Admin Menu OR Type any key to add another : ");

                if (input == "b" || input == "back")
                {
                    return;
                }

            }

        }
        public void AddAnimeToEmojiListInterface(List<string> emojiList)
        {
            Console.Write("Add Anime : ");
            string animeAdd = Console.ReadLine().Trim();
            Console.WriteLine(ValidateAddedAnime(animeAdd, emojiList));

        }
        public string ValidateAddedAnime(string anime, List<string> emojiType)
        {
            if (string.IsNullOrEmpty(anime))
            {
                return "Input cannot be empty...";
            }

            else if (emojiType.Contains(anime))
            {
                return $"Anime : {anime} already exists from the list";
            }

            emojiType.Add(anime);
            return $"{anime} added to the list.";

        }

        #endregion

        #region -- Remove Function --
        public void SelectedEmojiToRemove()
        {
            List<string> selectedEmojiList = null;
            while (true)
            {
                string adminInput = User.GetInput("Enter Emoji to Delete : ");


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
                    continue; // skips the next line of codes and go back to the top of the loop -> "Enter Emoji to Remove : "
                }

                Console.WriteLine("Current Anime List : ");
                foreach (var animeList in selectedEmojiList)
                {
                    Console.WriteLine(animeList);
                }

                RemoveAnimeToEmojiListInterface(selectedEmojiList);
                string continueOrNotInput = User.GetInput("Type [B] to go back to Admin Menu or type any key to delete another anime : ");

                if (continueOrNotInput == "b")
                {
                    return;
                }
            }

        }

        public void RemoveAnimeToEmojiListInterface(List<string> selectedEmojiList)
        {
            string animeRemove = User.GetInput("Delete Anime : ");
            Console.WriteLine(ValidateRemovedAnime(animeRemove, selectedEmojiList));
        }

        public string ValidateRemovedAnime(string animeInput, List<string> emojiList)
        {
            string anime = animeInput.ToUpper().Trim();
            if (string.IsNullOrEmpty(anime))
            {
                return "Input cannot be empty...";
            }

            else if (!emojiList.Contains(anime))
            {

                return $"Anime : {anime} doesn't exist from the list";
            }

            emojiList.Remove(anime);

            return $"Anime : {anime} has been removed to the list";


            
        }

        #endregion






    }
}
